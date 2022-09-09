<template>
  <div
    class="container col-lg-2 col-md-3 col-sm-4 col-xs-6"
    style="text-align: center"
  >
    <img src="@/assets/B2logo.png" alt="Paris" class="center" />
    <h1>{{ msgPessoas }}</h1>
    <table align="center">
      <thead>
        <tr>
          <th>ID</th>
          <th>NOME</th>
          <th>E-MAIL</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="pessoa in pessoas" v-bind:key="pessoa.id">
          <td>
            {{ pessoa.id }}
          </td>
          <td>
            {{ pessoa.nome }}
          </td>
          <td>
            {{ pessoa.email }}
          </td>
        </tr>
      </tbody>
    </table>

    
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "GetPessoas",
  props: {
    msgPessoas: String,
  },
  data: () => {
    return {
      pessoas: [],
    };
  },
  methods: {
    lista: (scope) => {
      axios
        .get("https://localhost:7060/ProjetoPraticoPDI/GetPessoas")
        .then((response) => {
          console.log(response.data);
          console.log(response.status);
          console.log(response.statusText);
          console.log(response.headers);
          console.log(response.config);
          scope.pessoas = response.data;
        });
    },
  },
  created() {
    this.lista(this);
  },
};
</script>
<style>
img {
  margin-left: auto;
  margin-right: auto;
}
</style>
