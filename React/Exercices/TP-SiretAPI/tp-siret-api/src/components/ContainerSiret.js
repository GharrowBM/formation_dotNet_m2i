import React from 'react';
import Entreprise from './Entreprise';
import SearchSiret from './SearchSiret';
import axios from "axios"
import { getSiretData } from '../actions/Entreprise';
import {connect} from "react-redux"
class ContainerSiret extends React.PureComponent {
    constructor(props) {
        super(props);
        // this.state = { 
        //     entreprise : undefined
        //  }
    }

    // search = (siret) => {
    //     //On effectue la recherche en utilisant l'api
    //     // axios.get("https://api.insee.fr/entreprises/sirene/V3/siret/"+siret, {headers : {'Authorization' : 'Bearer bb00ece6-22cd-3a2b-b477-0544c996fe2d'}})
    //     // .then(res => {
    //     //     if(res.data.header.statut === 200) {
    //     //         this.setState({
    //     //             entreprise : res.data.etablissement
    //     //         })
    //     //     }
    //     //     console.log(res.data);
    //     // }).catch(err => {
    //     //     console.log(err)
    //     // })
    // }
    render() { 
        return (
            <div className="container">
                <SearchSiret search={this.props.search}/>
                <Entreprise entreprise={this.props.entreprise}/>
            </div>
         );
    }
}
const mapStateToProps = (state) => {
    return {
        entreprise: state.entreprise.etablissement,
        isLoading: state.entreprise.isLoading,
    }
}
const mapActionToProps = (dispatch) => {
    return {
        search : (siret) => dispatch(getSiretData(siret))
    }
}
export default connect(mapStateToProps, mapActionToProps)(ContainerSiret);