<template>
    <div>
    <h1>{{ msgPessoas }}</h1>
    <table>
        <thead>
            <tr>
                <th>
                    ID
                </th>
                <th>
                    NOME
                </th>
                <th>
                    E-MAIL
                </th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="pessoa in pessoas" v-bind:key="pessoa.id" >
                <td>
                    {{pessoa.id}}
                </td>
                <td>
                    {{pessoa.nome}}
                </td>
                <td>
                    {{pessoa.email}}
                </td>
            </tr>
        </tbody>
    </table>
</div>
</template>

<script>
    import axios from 'axios';
export default {
  name: 'GetPessoas',
  props: {
    msgPessoas: String
  },
  data: () => {
    return {
        pessoas: []
    }
  },
  methods: {
    lista: (scope) => {
        axios.get('https://localhost:7060/ProjetoPraticoPDI/GetPessoas').then((res)=>{
            console.log("Oiiiiii")
            console.log(res)
            scope.pessoas = res.data
        })
    }    
  },
  created() {
    this.lista(this)
  }
}
</script>