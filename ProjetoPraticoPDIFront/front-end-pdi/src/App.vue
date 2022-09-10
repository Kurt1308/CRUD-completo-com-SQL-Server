<template>
  <div id="app">
    <HeaderApp />
    <img alt="Vue logo" src="./assets/B2logo.png">
    <TituloProjeto msg="Projeto prático PDI"/>
  </div>
</template>

<script>
import TituloProjeto from './components/TituloProjeto.vue';
import './styles/global.css';
import HeaderApp from './components/HeaderApp.vue';

export default {
  name: 'App',
  components: {
    TituloProjeto,
    HeaderApp,
}
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
