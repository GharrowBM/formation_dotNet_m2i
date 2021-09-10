<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="Resultat PREND_LA_VALEUR ValeurMaximum(Nb1,Nb2)" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2para="" F2defaut="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param nbDecimales="8" totalAffichages="1000" epaisseurPoint="2" maxBoucle="500000" arrondiAuto="vrai" epaisseurLigne="2" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions">
        <item algoitem="FONCTION ValeurMaximum(A,B)" code="201#ValeurMaximum#A,B">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction"/>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="SI (A>B) ALORS" code="6#A>B">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="RENVOYER A" code="205#A"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
                <item algoitem="SINON" code="9#sinon">
                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                    <item algoitem="RENVOYER B" code="205#B"/>
                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                </item>
            </item>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
    </item>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="Nb1 EST_DU_TYPE NOMBRE" code="1#NOMBRE#Nb1"/>
        <item algoitem="Nb2 EST_DU_TYPE NOMBRE" code="1#NOMBRE#Nb2"/>
        <item algoitem="Resultat EST_DU_TYPE NOMBRE" code="1#NOMBRE#Resultat"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir le premier nombre : &quot;" code="4#Veuillez saisir le premier nombre : #0"/>
        <item algoitem="LIRE Nb1" code="2#Nb1#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le deuxieme nombre : &quot;" code="4#Veuillez saisir le deuxieme nombre : #0"/>
        <item algoitem="LIRE Nb2" code="2#Nb2#pasliste"/>
        <item algoitem="Resultat PREND_LA_VALEUR ValeurMaximum(Nb1,Nb2)" code="5#Resultat#ValeurMaximum(Nb1,Nb2)#pasliste"/>
        <item algoitem="AFFICHER &quot;Le plus grand nombre est &quot;" code="4#Le plus grand nombre est #0"/>
        <item algoitem="AFFICHER Resultat" code="3#Resultat#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
