import React,{Component}  from 'react';
import axios from 'axios';
import {parseJwt} from '../../services/auth';
class Autor extends Component{
    constructor(props){
        super(props);
        this.state=  {
            ListaLivros : []
        }
        
    }
    ListarLivro=()=>{
        console.log("eita")
        fetch('http://localhost:5000/api/Livro/meu',{
            headers:{ 
                'Content-Type': 'application/json',
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login') 
             }
            })
        .then(responde => responde.json())
        .then(dados => this.setState({ ListaLivros: dados }))
        .catch(erro => console.log(erro))
    }
    componentDidMount() {

        this.ListarLivro()
      }
    render(){
    return( 
        <div>
            <main>
                <p>olá</p>
                <table>
                    <thead>
                        <tr>
                            <th>IdLivro</th>
                            <th>Idade do Autor</th>
                            <th>IdInstituicao</th>
                            <th>IdCategoria</th>
                            <th>Titulo</th>
                            <th>Sinopse</th>
                            <th>Data</th>
                            <th>Preço</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            this.state.ListaLivros.map((Livrinhos) =>{
                                return(
                                    <tr key={Livrinhos.idLivro}>
                                        <td>{Livrinhos.idLivro}</td>
                                        <td>{Livrinhos.idAutorNavigation.idade}</td>
                                        <td>{Livrinhos.idCategoriaNavigation.nomeCategoria}</td>
                                        <td>{Livrinhos.idInstituicaoNavigation.nomeInstituicao}</td>
                                        <td>{Livrinhos.titulo}</td>
                                        <td>{Livrinhos.sinopse}</td>
                                        <td>{Livrinhos.dataPublicacao}</td>
                                        <td>{Livrinhos.preco}</td>
                                    </tr>
                                )
                            })
                        }
                    </tbody>
                </table>
            </main>
        </div>
        )
    }
}
export default Autor;