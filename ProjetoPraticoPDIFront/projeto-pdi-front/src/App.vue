<template>
  <div
    class="container col-lg-2 col-md-3 col-sm-4 col-xs-6"
    style="text-align: center"
  >
  <HelloWorld msg="Projeto Prático PDI"/>
  <img src="@/assets/logo.png" alt="Paris" class="center" />
  </div>
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

