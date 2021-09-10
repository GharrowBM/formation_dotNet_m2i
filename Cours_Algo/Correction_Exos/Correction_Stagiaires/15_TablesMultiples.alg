<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="J EST_DU_TYPE NOMBRE"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2para="" F2defaut="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" nbDecimales="8" epaisseurPoint="2" maxBoucle="500000" epaisseurLigne="2" totalBoucles="5000000" totalAffichages="1000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="I EST_DU_TYPE NOMBRE" code="1#NOMBRE#I"/>
        <item algoitem="Message EST_DU_TYPE CHAINE" code="1#CHAINE#Message"/>
        <item algoitem="J EST_DU_TYPE NOMBRE" code="1#NOMBRE#J"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="POUR J ALLANT_DE 1 A 10" code="12#J#1#10">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="Message PREND_LA_VALEUR &quot;\nTable de &quot; + J" code="5#Message#&quot;\nTable de &quot; + J#pasliste"/>
            <item algoitem="AFFICHER Message" code="3#Message#1#pasliste"/>
            <item algoitem="POUR I ALLANT_DE 1 A 10" code="12#I#1#10">
                <item algoitem="DEBUT_POUR" code="13#debutpour"/>
                <item algoitem="Message PREND_LA_VALEUR &quot;\t&quot; + I + &quot; x &quot; + J + &quot; = &quot; + (I*J)" code="5#Message#&quot;\t&quot; + I + &quot; x &quot; + J + &quot; = &quot; + (I*J)#pasliste"/>
                <item algoitem="AFFICHER Message" code="3#Message#1#pasliste"/>
                <item algoitem="FIN_POUR" code="14#finpour"/>
            </item>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
