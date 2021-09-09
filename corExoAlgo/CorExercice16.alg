<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="NB EST_DU_TYPE NOMBRE" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2defaut="" F2lignes="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2" totalAffichages="1000" nbDecimales="8" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#MAX" algoitem="MAX EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#N" algoitem="N EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#MIN" algoitem="MIN EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#MOY" algoitem="MOY EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#SOM" algoitem="SOM EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#I" algoitem="I EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#CHOIX" algoitem="CHOIX EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#NB" algoitem="NB EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#SOM#0#pasliste" algoitem="SOM PREND_LA_VALEUR 0"/>
        <item code="5#NB#0#pasliste" algoitem="NB PREND_LA_VALEUR 0"/>
        <item code="12#I#1#5" algoitem="POUR I ALLANT_DE 1 A 5">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="4#Veuillez saisir la note N°#0" algoitem="AFFICHER &quot;Veuillez saisir la note N°&quot;"/>
            <item code="3#I#0#pasliste" algoitem="AFFICHER I"/>
            <item code="2#N#pasliste" algoitem="LIRE N"/>
            <item code="5#NB#NB+1#pasliste" algoitem="NB PREND_LA_VALEUR NB+1"/>
            <item code="5#SOM#SOM+N#pasliste" algoitem="SOM PREND_LA_VALEUR SOM+N"/>
            <item code="6#I==1" algoitem="SI (I==1) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#MAX#N#pasliste" algoitem="MAX PREND_LA_VALEUR N"/>
                <item code="5#MIN#N#pasliste" algoitem="MIN PREND_LA_VALEUR N"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="6#MIN >= N" algoitem="SI (MIN >= N) ALORS">
                        <item code="7#debutsi" algoitem="DEBUT_SI"/>
                        <item code="5#MIN#N#pasliste" algoitem="MIN PREND_LA_VALEUR N"/>
                        <item code="8#finsi" algoitem="FIN_SI"/>
                        <item code="9#sinon" algoitem="SINON">
                            <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                            <item code="6#MAX&lt;=N" algoitem="SI (MAX&lt;=N) ALORS">
                                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                <item code="5#MAX#N#pasliste" algoitem="MAX PREND_LA_VALEUR N"/>
                                <item code="8#finsi" algoitem="FIN_SI"/>
                            </item>
                            <item code="11#finsinon" algoitem="FIN_SINON"/>
                        </item>
                    </item>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="5#CHOIX#-1#pasliste" algoitem="CHOIX PREND_LA_VALEUR -1"/>
        <item code="15#CHOIX !=0" algoitem="TANT_QUE (CHOIX !=0) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="6#CHOIX==1" algoitem="SI (CHOIX==1) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="4# La plus petite note est : #0" algoitem="AFFICHER &quot; La plus petite note est : &quot;"/>
                <item code="3#MIN#1#pasliste" algoitem="AFFICHER MIN"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="6#CHOIX==2" algoitem="SI (CHOIX==2) ALORS">
                        <item code="7#debutsi" algoitem="DEBUT_SI"/>
                        <item code="4# La meilleure note est :#0" algoitem="AFFICHER &quot; La meilleure note est :&quot;"/>
                        <item code="3#MAX#1#pasliste" algoitem="AFFICHER MAX"/>
                        <item code="8#finsi" algoitem="FIN_SI"/>
                        <item code="9#sinon" algoitem="SINON">
                            <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                            <item code="6#CHOIX==3" algoitem="SI (CHOIX==3) ALORS">
                                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                <item code="5#MOY#SOM/NB#pasliste" algoitem="MOY PREND_LA_VALEUR SOM/NB"/>
                                <item code="4# La moyenne des notes est :#0" algoitem="AFFICHER &quot; La moyenne des notes est :&quot;"/>
                                <item code="3#MOY#1#pasliste" algoitem="AFFICHER MOY"/>
                                <item code="8#finsi" algoitem="FIN_SI"/>
                            </item>
                            <item code="11#finsinon" algoitem="FIN_SINON"/>
                        </item>
                    </item>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="4#Veuillez faire votre choix :#1" algoitem="AFFICHER &quot;Veuillez faire votre choix :&quot;"/>
            <item code="4#\t1) Afficher la plus petite note\n\t2) Afficher la plus grande note\n\t3) Afficher la moyenne des notes#0" algoitem="AFFICHER &quot;\t1) Afficher la plus petite note\n\t2) Afficher la plus grande note\n\t3) Afficher la moyenne des notes&quot;"/>
            <item code="2#CHOIX#pasliste" algoitem="LIRE CHOIX"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
