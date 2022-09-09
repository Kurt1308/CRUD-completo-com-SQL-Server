<template>
  <HelloWorld msg="Projeto Prático PDI"/>
  <GetPessoas msgPessoas="Projeto Prático PDI"/>
</template>

<script>
import GetPessoas from './components/GetPessoas.vue';

export default {
  name: 'App',
  components: {
    GetPessoas
}
}
</script>

