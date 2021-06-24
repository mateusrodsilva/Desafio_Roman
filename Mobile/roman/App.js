import React, { Component } from 'react';
import { render } from 'react-dom';
import { FlatList, Image, StyleSheet, Text, View } from 'react-native';

import api from './src/services/api';


export default class App extends Component() 
{
  constructor(props){
    super(props);
    this.state = {
      listaProjetos: [],
    }
  }
}

buscarProjetos = async () => {
  const resposta = await api.get('/projetos');
  const dadosDaApi = resposta.data;
  this.setState ({listaProjetos: dadosDaApi});
}

componentDidMount() {
  this.buscarProjetos()
}

render() {

}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },

});
