import Vue from 'vue'
import App from './App.vue'
//import VueRouter from 'vue-router';
//import GetAll from './pages/GetAll';

//Vue.use(VueRouter);

// const router = new VueRouter({
//     routes: [{
//       path: '/getAll',
//       component: GetAll
//     }]
// });

Vue.config.productionTip = false

new Vue({
  //router,
  render: h => h(App),
}).$mount('#app')
