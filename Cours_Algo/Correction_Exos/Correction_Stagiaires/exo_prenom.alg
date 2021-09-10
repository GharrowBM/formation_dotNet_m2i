<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="APPELER_FONCTION AFFICHAGE()"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2para="" F2lignes="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" nbDecimales="8" maxBoucle="500000" arrondiAuto="vrai" totalAffichages="1000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES">
        <item code="201#AFFICHAGE# " algoitem="FONCTION AFFICHAGE( )">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION"/>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="206#NOM()" algoitem="APPELER_FONCTION NOM()"/>
            <item code="206#PRENOM()" algoitem="APPELER_FONCTION PRENOM()"/>
            <item code="3#ETAT_CIVIL#0#pasliste" algoitem="AFFICHER ETAT_CIVIL"/>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
        <item code="201#NOM# " algoitem="FONCTION NOM( )">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION">
                <item code="1#CHAINE#nom" algoitem="nom EST_DU_TYPE CHAINE"/>
            </item>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="4#Donnez votre nom.#0" algoitem="AFFICHER &quot;Donnez votre nom.&quot;"/>
            <item code="2#nom#pasliste" algoitem="LIRE nom"/>
            <item code="5#ETAT_CIVIL#nom#pasliste" algoitem="ETAT_CIVIL PREND_LA_VALEUR nom"/>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
        <item code="201#PRENOM# " algoitem="FONCTION PRENOM( )">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION">
                <item code="1#CHAINE#prenom" algoitem="prenom EST_DU_TYPE CHAINE"/>
            </item>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="4#Donnez votre Prénom#1" algoitem="AFFICHER &quot;Donnez votre Prénom&quot;"/>
            <item code="2#prenom#pasliste" algoitem="LIRE prenom"/>
            <item code="5#ETAT_CIVIL#ETAT_CIVIL +&quot; &quot;+ prenom#pasliste" algoitem="ETAT_CIVIL PREND_LA_VALEUR ETAT_CIVIL +&quot; &quot;+ prenom"/>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
    </item>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#ETAT_CIVIL" algoitem="ETAT_CIVIL EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="206#AFFICHAGE()" algoitem="APPELER_FONCTION AFFICHAGE()"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
