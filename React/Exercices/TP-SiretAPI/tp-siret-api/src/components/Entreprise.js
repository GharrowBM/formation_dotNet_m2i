import React from "react"

const Entreprise = (props) => {
    console.log(props);
    return (
        <div className="row entreprise">
            {props.entreprise !== undefined ? (
                <div className="col">
                    <div className="row m-1">
                        <div className="col-3 offset-1">SIRET : </div>
                        <div className="col">{props.entreprise.siret}</div>
                    </div>
                    <div className="row m-1">
                        <div className="col-3 offset-1">Nom entreprise : </div>
                        <div className="col">{props.entreprise.uniteLegale.denominationUniteLegale}</div>
                    </div>
                    <div className="row m-1">
                        <div className="col-3 offset-1">Siège social : </div>
                        <div className="col">{props.entreprise.etablissementSiege? "Oui":"Non"}</div>
                    </div>
                    <div className="row m-1">
                        <div className="col-3 offset-1">Date de création : </div>
                        <div className="col">{props.entreprise.dateCreationEtablissement}</div>
                    </div>
                    <div className="row m-2">
                        <div className="col-3 offset-1">Date dernier traitement : </div>
                        <div className="col">{props.entreprise.dateDernierTraitementEtablissement}</div>
                    </div>
                    <div className="row m-1">
                        <div className="col-3 offset-1">Adresse : </div>
                        <div className="col">
                            {props.entreprise.adresseEtablissement.numeroVoieEtablissement ?
                                props.entreprise.adresseEtablissement.numeroVoieEtablissement + ' ' : ''}
                            {props.entreprise.adresseEtablissement.typeVoieEtablissement ?
                                props.entreprise.adresseEtablissement.typeVoieEtablissement + ' ' : ''}
                            {props.entreprise.adresseEtablissement.libelleVoieEtablissement + ' '}
                            {props.entreprise.adresseEtablissement.libelleCommuneEtablissement + ' '}
                            {props.entreprise.adresseEtablissement.codePostalEtablissement + ' '}
                            <div>{props.entreprise.adresseEtablissement.complementAdresseEtablissement}</div>
                        </div>
                    </div>
                </div>
            ) : null}
        </div>
    )
}

export default Entreprise