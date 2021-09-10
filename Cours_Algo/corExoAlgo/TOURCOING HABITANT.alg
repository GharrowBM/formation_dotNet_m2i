<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="POPU_BASE PREND_LA_VALEUR round(POPU_BASE * ( 1 + ACCROISSEMENT ))" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2lignes="" F2para="" F2etat="inactif" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param arrondiAuto="vrai" epaisseurPoint="2" nbDecimales="8" maxBoucle="500000" epaisseurLigne="2" totalAffichages="1000" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="ACCROISSEMENT EST_DU_TYPE NOMBRE" code="1#NOMBRE#ACCROISSEMENT"/>
        <item algoitem="NB_ANNEE EST_DU_TYPE NOMBRE" code="1#NOMBRE#NB_ANNEE"/>
        <item algoitem="POPU_BASE EST_DU_TYPE NOMBRE" code="1#NOMBRE#POPU_BASE"/>
        <item algoitem="POPU_RECHERCHE EST_DU_TYPE NOMBRE" code="1#NOMBRE#POPU_RECHERCHE"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="NB_ANNEE PREND_LA_VALEUR 0" code="5#NB_ANNEE#0#pasliste"/>
        <item algoitem="AFFICHER &quot;QUEL POPU A LA BASE? EN NB D'HABITANT&quot;" code="4#QUEL POPU A LA BASE? EN NB D'HABITANT#0"/>
        <item algoitem="LIRE POPU_BASE" code="2#POPU_BASE#pasliste"/>
        <item algoitem="AFFICHER &quot;QUEL POPU RECHERCHE? EN NB D'HABITANT&quot;" code="4#QUEL POPU RECHERCHE? EN NB D'HABITANT#0"/>
        <item algoitem="LIRE POPU_RECHERCHE" code="2#POPU_RECHERCHE#pasliste"/>
        <item algoitem="AFFICHER &quot;A QUEL ACCROISSEMENT ? EN %&quot;" code="4#A QUEL ACCROISSEMENT ? EN %#0"/>
        <item algoitem="LIRE ACCROISSEMENT" code="2#ACCROISSEMENT#pasliste"/>
        <item algoitem="ACCROISSEMENT PREND_LA_VALEUR ACCROISSEMENT / 100" code="5#ACCROISSEMENT#ACCROISSEMENT / 100#pasliste"/>
        <item algoitem="TANT_QUE (POPU_BASE &lt;=  POPU_RECHERCHE) FAIRE" code="15#POPU_BASE &lt;=  POPU_RECHERCHE">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="POPU_BASE PREND_LA_VALEUR round(POPU_BASE * ( 1 + ACCROISSEMENT ))" code="5#POPU_BASE#round(POPU_BASE * ( 1 + ACCROISSEMENT ))#pasliste"/>
            <item algoitem="NB_ANNEE PREND_LA_VALEUR NB_ANNEE + 1" code="5#NB_ANNEE#NB_ANNEE + 1#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;EN &quot;" code="4#EN #0"/>
        <item algoitem="AFFICHER NB_ANNEE" code="3#NB_ANNEE#0#pasliste"/>
        <item algoitem="AFFICHER &quot; ANNEES LA POPULATION SERA DE &quot;" code="4# ANNEES LA POPULATION SERA DE #0"/>
        <item algoitem="AFFICHER POPU_BASE" code="3#POPU_BASE#0#pasliste"/>
        <item algoitem="AFFICHER &quot; HABITANTS&quot;" code="4# HABITANTS#0"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
