<template>
  <div id="app">
    <nav>
      <div class="nav-wrapper green darken-1">
        <a href="#" class="brand-logo center">Frutas</a>
      </div>
    </nav>
    <div class="container teste">
      <table>
        <thead>
          <tr>
            <th>Nome</th>
            <th>Preço A</th>
            <th>Preço B</th>
            <th>Ação</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="fruit of fruits" :key="fruit.id">
            <td>{{ fruit.name }}</td>
            <td>{{ fruit.priceA }}</td>
            <td>{{ fruit.priceB  }}</td>
            <td>
              <a class="waves-effect green waves-light btn" @click="openDialog(fruit)">Selecionar</a>
            </td>
          </tr>
        </tbody> 
      </table>
    </div>
    <div v-if="this.dialog">
      <v-app>
      <FruitModal :fruit="selectedFruit" :open-modal="this.dialog"/>
    </v-app>
    </div>
  </div>
</template>

<script>
import fruitApi from '../services/fruitApi';

import FruitModal from './components/FruitModal.vue';

export default {
  components:{
    FruitModal
  },
  name: 'App',
  data() {
    return {
    fruits: [],
    errors:[],
    selectedFruit: {},
    dialog: false,
    }
  },
  mounted(){
    this.loadData()
  },
  methods: {
    loadData(){
      fruitApi.getFruits().then((res) => {
        this.fruits = res.data.data
      }).catch((error) => {
        this.errors = error.message
      })
    },
    openDialog(data){
      this.selectedFruit = data
      this.dialog = true
    }
  },
}
</script>
<style>
</style>
