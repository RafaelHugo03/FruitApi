<template>
  <div>
      <v-dialog
      v-model="dialog"
      persistent
      max-width="500"
      >
        <v-card>
          <v-card-title class="text-h5">
            Frutas 
          </v-card-title>
          <v-divider></v-divider>
              
          <div class="container center top-dist">
            <div class="label-align-left">
            <label>Descrição</label>
            </div>
            <div class="top-dist">
              <p class="box top-dist">{{ fruit.name }}</p>
            </div>
            <div class="label-align-left">
            <label>Preço A</label>
            </div>
            <div class="top-dist">
              <p class="box top-dist">{{ fruit.priceA }}</p>
            </div>
            <div class="label-align-left">
            <label>Preço B</label>
            </div>
            <div class="top-dist">
              <p class="box top-dist">{{ fruit.priceB }}</p>
            </div>
            <div class="label-align-left">
            <label>Resultado</label>
            </div>
            <div class="top-dist">
              <p class="box top-dist">{{ this.operationResult }}</p>
            </div>
            <div class="top-dist">
              <v-btn
              class="btn-size"
              color="green darken 1"
              @click="multiply()">Multiplicar
            </v-btn>
            <v-btn
              class="btn-size"
              color="green darken 1"
              @click="division()">Dividir
            </v-btn>
            </div>
          </div>

          <div class="top-dist">
            <v-divider></v-divider>
          </div>

          <v-card-actions>
            <v-spacer ></v-spacer>
            <div class="top-dist">
            <v-btn
              color="red darken-1"
              @click="closeModal()"
            >
              Cancelar
            </v-btn>
            </div>
          </v-card-actions>
        </v-card>
    </v-dialog>
  </div>
</template>

<script>
  export default {
    name: "FruitModal",
    props:{
      fruit: {},
      openModal: Boolean
    },
    data () {
      return {
        dialog: false,
        operationResult: ''
      }
    },
    created(){
      this.dialog = this.openModal
    },
    methods:{
      multiply(){
        this.operationResult = this.fruit.priceA * this.fruit.priceB

      },
      division(){
        this.operationResult = this.fruit.priceA / this.fruit.priceB
      },
      closeModal(){
        this.dialog = false
        location.reload()
      },
      Modal(){
        this.dialog = this.openModal
      }
    }
  }
</script>

<style>
label {
  font-size: 25px;
  color: black;
}
.box {
  width: 350px;
    height: 60px;
    background: white;
    color: black;
    padding: 15px;
    border: 2px solid #CCC;
}
.top-dist {
  padding-top: 18px;
}
.v-btn{
  margin: 0 30px;
}
.btn-size{
  width: 115px;
}
.label-align-left{
  text-align: left;
}
</style>