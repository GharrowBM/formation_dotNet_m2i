<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="NoimComplet EST_DU_TYPE CHAINE" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2lignes="" F2etat="inactif" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param maxBoucle="500000" totalBoucles="5000000" epaisseurPoint="2" nbDecimales="8" epaisseurLigne="2" totalAffichages="1000" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions">
        <item algoitem="FONCTION PRENOOM( )" code="201#PRENOOM# ">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction">
                <item algoitem="PRENOM EST_DU_TYPE CHAINE" code="1#CHAINE#PRENOM"/>
            </item>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="AFFICHER &quot;SI TU NE ME DIS PAS TON PRENOM J'APPELLE DARK VADOR&quot;" code="4#SI TU NE ME DIS PAS TON PRENOM J'APPELLE DARK VADOR#0"/>
            <item algoitem="LIRE PRENOM" code="2#PRENOM#pasliste"/>
            <item algoitem="RENVOYER PRENOM" code="205#PRENOM"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
        <item algoitem="FONCTION NOOM( )" code="201#NOOM# ">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction">
                <item algoitem="NOM EST_DU_TYPE CHAINE" code="1#CHAINE#NOM"/>
            </item>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="AFFICHER &quot;BIENVENUE A TOI JEUNE JEDI, QUEL EST TON NOM?&quot;" code="4#BIENVENUE A TOI JEUNE JEDI, QUEL EST TON NOM?#0"/>
            <item algoitem="LIRE NOM" code="2#NOM#pasliste"/>
            <item algoitem="RENVOYER NOM" code="205#NOM"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
        <item algoitem="FONCTION JEDI( )" code="201#JEDI# ">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction">
                <item algoitem="A EST_DU_TYPE CHAINE" code="1#CHAINE#A"/>
                <item algoitem="B EST_DU_TYPE CHAINE" code="1#CHAINE#B"/>
                <item algoitem="AB EST_DU_TYPE CHAINE" code="1#CHAINE#AB"/>
            </item>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="A PREND_LA_VALEUR NOOM()" code="5#A#NOOM()#pasliste"/>
            <item algoitem="B PREND_LA_VALEUR PRENOOM()" code="5#B#PRENOOM()#pasliste"/>
            <item algoitem="AB PREND_LA_VALEUR A+&quot; &quot;+B" code="5#AB#A+&quot; &quot;+B#pasliste"/>
            <item algoitem="AFFICHER &quot;OLA PADAWAN&quot;" code="4#OLA PADAWAN#1"/>
            <item algoitem="RENVOYER AB" code="205#AB"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
    </item>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="NoimComplet EST_DU_TYPE CHAINE" code="1#CHAINE#NoimComplet"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="NoimComplet PREND_LA_VALEUR JEDI()" code="5#NoimComplet#JEDI()#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
