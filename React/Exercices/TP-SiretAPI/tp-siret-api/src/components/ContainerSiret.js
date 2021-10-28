import React from 'react';
import Entreprise from './Entreprise';
import SearchSiret from './SearchSiret';
import axios from "axios"

class ContainerSiret extends React.PureComponent {
    constructor(props) {
        super(props);
        this.state = { 
            entreprise : undefined
         }
    }

    search = (siret) => {
        //On effectue la recherche en utilisant l'api
        axios.get("https://api.insee.fr/entreprises/sirene/V3/siret/"+siret, {headers : {'Authorization' : 'Bearer 92a85b30-ce60-3524-be59-84ff2f981773'}})
        .then(res => {
            if(res.data.header.statut === 200) {
                this.setState({
                    entreprise : res.data.etablissement
                })
            }
            console.log(res.data);
        }).catch(err => {
            console.log(err)
        })
    }
    render() { 
        return (
            <div className="container">
                <SearchSiret search={this.search}/>
                <Entreprise entreprise={this.state.entreprise}/>
            </div>
         );
    }
}
 
export default ContainerSiret;