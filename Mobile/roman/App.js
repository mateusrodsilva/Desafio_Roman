import React, { Component } from 'react';
import { render } from 'react-dom';
import { FlatList, TextInput,Image, StyleSheet, Text, View, TouchableOpacity } from 'react-native';

import api from './src/services/api';


export default class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      listaProjetos: []
    }
  }


  buscarProjetos = async () => {
    const resposta = await api.get('/1');
    const dadosDaApi = resposta.data;
    this.setState({ listaProjetos: dadosDaApi });
  }

  componentDidMount() {
    this.buscarProjetos()
  }

  render() {
    return (
      <View style={styles.container}>
        <View style={styles.content}>
          <View>
            <Text style={styles.logo}>ROMAN</Text>
          </View>


          <View style={styles.areaLogin}>
            <Text style={styles.textLogin}>LOGIN</Text>
            <View>
              <View style={styles.areaInput}>
                <Text style={styles.textinputs}>E-mail ou nome de Usuário</Text>
                <TextInput style={styles.estiloInput}></TextInput>
              </View>
              <View style={styles.areaInput}>
                <Text style={styles.textinputs}>Senha</Text>
                <TextInput style={styles.estiloInput}></TextInput>
              </View>
            </View>
          </View>


          <View style={styles.areaButton}>
            <TouchableOpacity style={styles.espacoBotao}>
              <Text style={styles.textEntrar}>Entrar</Text>
            </TouchableOpacity>
            {/* <TouchableOpacity style={styles.espacoBotao}>
              <Text style={styles.textEntrar}>Cadastrar</Text>
            </TouchableOpacity> */}
          </View>

        </View>

      </View>
    );

  }

  renderizaItem = ({ item }) => {
    <View style={styles.flatItemLinha}>
    </View>
  }
}
const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  content: {
    backgroundColor: '#221E1E',
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'column',
    width: '100%',
    height: '90%'
    
  },
  logo: {
    color: '#C52020',
    fontFamily: 'Rock Salt',
    fontSize: '36px',
    paddingBottom: '40%'
  },
  areaLogin: {
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'column',
  },
  textLogin: {
    fontFamily: 'SeoulNamsan CBL',
    color: '#C4C4C4',
    fontSize: '26px',
  },
  textinputs: {
    fontFamily: 'SeoulNamsan CBL',
    fontSize: '12px',
    color: '#ffffff',
    paddingTop: '10px'
  },
  estiloInput: {
    backgroundColor: '#EDE9DD',
    width: '100%'
  },
  areaInput: {
    alignItems: 'flex-start',
    justifyContent: 'center'
  },
  espacoBotao: {
    backgroundColor: '#175D84',
    alignItems: 'center',
    justifyContent: 'center',
    textAlignVertical: 'bottom',
    margin: '20px',
    paddingLeft: '5px',
    paddingRight: '5px',
  },
  textEntrar: {
    paddingTop: '10%',
    textAlign: 'center',
    textAlignVertical: 'bottom',
    fontFamily: 'SeoulNamsan CBL',
    color: '#ffffff',
    width: 70,
    height: 30,
  },
  areaButton: {
    flexDirection:'row',
    justifyContent: 'space-between' 
  },

});
