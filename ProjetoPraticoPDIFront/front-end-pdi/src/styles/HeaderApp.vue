<template>
    <header>   
        <nav class="container">
            <img v-on:click="openMenu" alt="Abrir menu" id="menu-button" src="https://raw.githubusercontent.com/william-costa/wdev-mock-site-resources/master/assets/images/menu.svg">
            <div v-on:click="closeMenu" id="menu-overlay" v-if="menuActive"></div>
            <div id="menu-items" :class="{active:menuActive}">               
                <ul>
                    <li>
                        <a href="/getAll">Get all</a>
                    </li>
                    <li>
                        <a href="getById">Get by Id</a>
                    </li>
                    <li>
                        <a href="/insert">Insert</a>
                    </li>
                    <li>
                        <a href="/delete">Delete</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>
</template>

<script>
export default {
    name: 'HeaderApp',
    data(){
        return{
            menuActive: false
        }
    },
    methods: {
        openMenu: function(){
            this.menuActive = true;
        },
        closeMenu: function(){
            this.menuActive = false;
        }
    },
}
</script>

<style scoped>
    header{
        background-color: var(--color-background-nav);
        height: 60px;
        width: 100%;
        display: flex
    }
    #menu-button{
        width: 60px;
    }
    #menu-overlay{
        position: fixed;
        top: 0;
        right: 0;
        width: 40%;
        height: 100vh;
        backgroung-color: #000000;
        opacity: 0.8;
    }
    #menu-logo{
        width: 110px;
    }
    #menu-items{
        position: fixed;
        top: 0;
        right: 0;
        background-color: var(--color-background-nav);
        width: 60%;
        height: 100vh;
        display: none;
        flex-direction: column;
        justify-content: flex-start;
        align-items: center;
    }
    #menu-items.active{
        display: flex;
    }
    ul{
        text-align: center;
        list-style: none;
    }
    ul li{
        margin: 20px 0px;
    }
    ul li a{
        color: var(--color-text-light);
    }

    @media (min-width: 900px){
        #menu-button,
        #menu-logo,
        #menu-overlay{
            display: none;
        }
        #menu-items{
            display: flex;
            position: static;
            height: 60px;
            width: auto;
        }
        ul{
            display: flex;
            height: 60px;
            align-items: center;
        }
        ul li{
            margin: 0;
            margin-left: 20px;
        }
    }

    nav{
        display: flex;
        justify-content: left;
        margin-left: 150px;
        height: 60px;
        align-items: center;
    }
</style>
