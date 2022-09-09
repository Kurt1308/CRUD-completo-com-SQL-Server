<template lang="html">
  <div
    class="container col-lg-2 col-md-3 col-sm-4 col-xs-6"
    style="text-align: center"
  >
    <img src="@/assets/B2logo.png" alt="Paris" class="center" />
    <h1 align="center">{{ msg }}</h1>

    <div size="50" style="margin-top:30px">
    <button>Get all</button>
    </div>
    <div style="margin-top:30px">
    <button>Get by Id</button>
    </div>
    <div style="margin-top:30px">
    <button>Insert</button>
    </div>
    <div style="margin-top:30px">
    <button>Delete</button>
    </div>
    <div style="margin-top:90px"></div>
    <a href="https://localhost:7060/swagger/index.html" @click.prevent="notify">
      Acessar API
    </a>
  </div>
</template>

<script>
export default {
  name: "HelloWorld",
  props: {
    msg: String,
  },
  methods: {
    // reverseMessage() {
    //   this.message = this.message.split("").reverse().join("");
    // },
    notify() {
      alert("https://localhost:7060/swagger/index.html");
    },
  },
};
</script>
<style lang="css">
img {
  margin-left: auto;
  margin-right: auto;
}
</style>
