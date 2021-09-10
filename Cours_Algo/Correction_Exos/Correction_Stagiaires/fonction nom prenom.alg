<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="APPELER_FONCTION Utilisateur(N,P)"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2defaut="" F2para=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalBoucles="5000000" maxBoucle="500000" arrondiAuto="vrai" epaisseurLigne="2" epaisseurPoint="2" nbDecimales="8" totalAffichages="1000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions">
        <item algoitem="FONCTION DemanderNom( )" code="201#DemanderNom# ">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction">
                <item algoitem="NomTmp EST_DU_TYPE CHAINE" code="1#CHAINE#NomTmp"/>
            </item>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="AFFICHER &quot;Entrez votre nom&quot;" code="4#Entrez votre nom#0"/>
            <item algoitem="LIRE NomTmp" code="2#NomTmp#pasliste"/>
            <item algoitem="RENVOYER NomTmp" code="205#NomTmp"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
        <item algoitem="FONCTION DemanderPrenom( )" code="201#DemanderPrenom# ">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction">
                <item algoitem="PrenomTmp EST_DU_TYPE CHAINE" code="1#CHAINE#PrenomTmp"/>
            </item>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="AFFICHER &quot;Entrez votre prenom&quot;" code="4#Entrez votre prenom#0"/>
            <item algoitem="LIRE PrenomTmp" code="2#PrenomTmp#pasliste"/>
            <item algoitem="RENVOYER PrenomTmp" code="205#PrenomTmp"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
        <item algoitem="FONCTION Utilisateur( nom,prenom)" code="201#Utilisateur# nom,prenom">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction"/>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="AFFICHER &quot;Le nom de l'utisateur est &quot;" code="4#Le nom de l'utisateur est #0"/>
            <item algoitem="AFFICHER N" code="3#N#0#pasliste"/>
            <item algoitem="AFFICHER &quot; son prenom est &quot;" code="4# son prenom est #0"/>
            <item algoitem="AFFICHER P" code="3#P#0#pasliste"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
    </item>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="N EST_DU_TYPE CHAINE" code="1#CHAINE#N"/>
        <item algoitem="P EST_DU_TYPE CHAINE" code="1#CHAINE#P"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="N PREND_LA_VALEUR DemanderNom" code="5#N#DemanderNom#pasliste"/>
        <item algoitem="P PREND_LA_VALEUR DemanderPrenom" code="5#P#DemanderPrenom#pasliste"/>
        <item algoitem="APPELER_FONCTION Utilisateur(N,P)" code="206#Utilisateur(N,P)"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
