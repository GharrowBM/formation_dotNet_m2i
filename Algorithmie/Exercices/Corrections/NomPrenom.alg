<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;Votre nom complet est : &quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2lignes="" F2etat="inactif" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurLigne="2" maxBoucle="500000" nbDecimales="8" totalAffichages="1000" totalBoucles="5000000" epaisseurPoint="2" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="NOM EST_DU_TYPE CHAINE" code="1#CHAINE#NOM"/>
        <item algoitem="PRENOM EST_DU_TYPE CHAINE" code="1#CHAINE#PRENOM"/>
        <item algoitem="Nom_Complet EST_DU_TYPE CHAINE" code="1#CHAINE#Nom_Complet"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir votre nom : &quot;" code="4#Veuillez saisir votre nom : #0"/>
        <item algoitem="LIRE NOM" code="2#NOM#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir votre prénom : &quot;" code="4#Veuillez saisir votre prénom : #0"/>
        <item algoitem="LIRE PRENOM" code="2#PRENOM#pasliste"/>
        <item algoitem="Nom_Complet PREND_LA_VALEUR NOM +&quot; &quot;+ PRENOM" code="5#Nom_Complet#NOM +&quot; &quot;+ PRENOM#pasliste"/>
        <item algoitem="AFFICHER &quot;Votre nom complet est : &quot;" code="4#Votre nom complet est : #0"/>
        <item algoitem="AFFICHER Nom_Complet" code="3#Nom_Complet#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
