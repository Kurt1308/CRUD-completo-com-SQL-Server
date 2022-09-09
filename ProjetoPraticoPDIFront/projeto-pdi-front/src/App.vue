<template>
  <HelloWorld msg="Projeto Prático PDI"/>
  <GetPessoas msgPessoas="Projeto Prático PDI"/>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
//import GetPessoas from './components/GetPessoas.vue';

export default {
  name: 'App',
  components: {
    HelloWorld,
    //GetPessoas
}
}
</script>

