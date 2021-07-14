
import './App.css';
import React,{Component}  from 'react';
import axios from 'axios';
import { usuarioAutenticado } from '../../services/auth';
class App extends Component{
    constructor(props){
        super(props);
        this.state=  {
        ListaLivros : [],
        IdLivro : 0,
        nomeCategoria : "",
        nomeInstituicao : "", CNPJ: "", Endereco:"",      
        UsuarioNome : "", UsuarioTipo : 0 , UsuarioEmail : "", UsuarioSenha : "" , 
        Autor:0, CategoriaId :0,Instituicao : 0,Titulo :"",Sinopse:"",Data :"", Preco:0                   
        }
    
    
    }
    ListarLivro=()=>{
        console.log("eita")
        fetch('http://localhost:5000/api/Livro')
        .then(responde => responde.json())
        .then(dados => this.setState({ ListaLivros: dados }))
        .catch(erro => console.log(erro))
    }
    CadastrarCategoria = async(event) =>{
        event.preventDefault();
        console.log(localStorage.getItem('usuario-login'))
         fetch('http://localhost:5000/api/categoria',{
            method: "POST",
        
        body: JSON.stringify({nomeCategoria : this.state.nomeCategoria}),
        
        headers: {
            'Content-Type': 'application/json',
            'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
          }
        })
        console.log(localStorage.getItem('usuario-login'))
    }


    CadastrarInstituicao = async() =>{
         fetch('http://localhost:5000/api/instituicao',{
            method: "POST",
            body:JSON.stringify({
                nomeInstituicao: this.state.nomeInstituicao,
                cnpj : this.state.CNPJ,
                endereco : this.state.Endereco}),
                headers: {
                    'Content-Type': 'application/json',
                    'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
                  }
               
        })
    }


    CadastrarUsuario = async () =>{
        fetch('http://localhost:5000/api/usuario',{
        method: "POST",
        body:JSON.stringify({
        NomeUsuario : this.state.UsuarioNome,
        idTipoUsuario : this.state.UsuarioTipo,
        email : this.state.UsuarioEmail,
        senha : this.state.UsuarioSenha
            }),
            headers: {
                'Content-Type': 'application/json',
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
              }
        })
       
    }
   // Autor:0, CategoriaId :0,Instituicao : 0,Titulo :"",Sinopse:"",Data :"", Preco:0 
    CadastrarLivro = async () =>{
        fetch('http://localhost:5000/api/livro',{
            
        method: "POST",
        body:JSON.stringify({
        idAutor : this.state.Autor,
        idCAtegoria : this.state.CategoriaId,
        idInstituicao : this.state.Instituicao,
       titulo: this.state.Titulo,
        Sinopse : this.state.Sinopse,
        dataPublicacao : this.state.Data,
        preco : this.state.Preco
            }),
        headers: {
                'Content-Type': 'application/json',
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
    }
    componentDidMount() {

        this.ListarLivro()
      }
      AtualizaStateCampo = async (campo) => {
        await this.setState({ [campo.target.name]: campo.target.value })
      };
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
                <form onSubmit={this.CadastrarCategoria}>
                        <input type = "text" name="nomeCategoria" value={this.state.nomeCategoria} onChange={this.AtualizaStateCampo}placeholder = "Categoria"  />
                        <button type ="submit">Categoria</button>
                </form>
                <form onSubmit={this.CadastrarInstituicao}>
                        <input type = "text" name="nomeInstituicao" value={this.state.nomeInstituicao} onChange={this.AtualizaStateCampo}placeholder = "Instituicao"  />
                        <input type = "text" name="CNPJ" value={this.state.CNPJ} onChange={this.AtualizaStateCampo}placeholder = "CNPJ"  />
                        <input type = "text" name="Endereco" value={this.state.Endereco} onChange={this.AtualizaStateCampo}placeholder = "Endereço"  />
                        <button type ="submit">instituicao</button>
                </form>
                <form onSubmit={this.CadastrarUsuario}>
                        <input type = "text" name="UsuarioNome" value={this.state.UsuarioNome} onChange={this.AtualizaStateCampo}placeholder = "Nome"  />
                        <input type = "number" name="UsuarioTipo" value={this.state.UsuarioTipo} onChange={this.AtualizaStateCampo}placeholder = "Tipo"  />
                        <input type = "text" name="UsuarioEmail" value={this.state.UsuarioEmail} onChange={this.AtualizaStateCampo}placeholder = "Email"  />
                        <input type = "text" name="UsuarioSenha" value={this.state.UsuarioSenha} onChange={this.AtualizaStateCampo}placeholder = "Senha"  />
                        <button type ="submit">Usuario</button>
                </form>
                <form onSubmit={this.CadastrarLivro}>
                {/* // Autor:0, CategoriaId :0,Instituicao : 0,Titulo :"",Sinopse:"",Data :"", Preco:0  */}
                        <input type = "number" name="Autor" value={this.state.Autor} onChange={this.AtualizaStateCampo}placeholder = "IdAutor"  />
                        <input type = "number" name="CategoriaId" value={this.state.CategoriaId} onChange={this.AtualizaStateCampo}placeholder = "IdCategoria"  />
                        <input type = "number" name="Instituicao" value={this.state.Instituicao} onChange={this.AtualizaStateCampo}placeholder = "IdIstituição"  />
                        <input type = "text" name="Titulo" value={this.state.Titulo} onChange={this.AtualizaStateCampo}placeholder = "Titulo"  />
                        <input type = "text" name="Sinopse" value={this.state.Sinopse} onChange={this.AtualizaStateCampo}placeholder = "Sinopse"  />
                        <input type = "text" name="Data" value={this.state.Data} onChange={this.AtualizaStateCampo}placeholder = "Data"  />
                        <input type = "number" name="Preco" value={this.state.Preco} onChange={this.AtualizaStateCampo}placeholder = "Preço"  />
                        <button type ="submit">Livro</button>
                </form>
            </main>
        </div>
        )
    }
  }

export default App;
