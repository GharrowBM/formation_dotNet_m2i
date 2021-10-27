import React, { PureComponent } from 'react';

class SearchSiret extends PureComponent {
    constructor(props) {
        super(props);
        this.state = { 
            siret : ''
         }
    }

    changeSiret = (e) => {
        this.setState({ siret: e.target.value });
    }
    searchClick = () => {
        this.props.search(this.state.siret)
        this.setState({ siret: '' });
    }
    render() { 
        return (
            <div className="row justify-content-center">
                <input type="text" value={this.state.siret} onChange={this.changeSiret} placeholder="Merci de saisir un siret" className="col form-control" />
                <button onClick={this.searchClick} className="col-3 btn btn-primary">Rechercher</button>
            </div>
        );
    }
}
 
export default SearchSiret;