<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="POUR ETUDIANT_i ALLANT_DE 1 A N" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2lignes="" F2etat="inactif" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param maxBoucle="500000" nbDecimales="8" epaisseurLigne="2" totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000" arrondiAuto="vrai"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#ETUDIANT_i" algoitem="ETUDIANT_i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#MATIERE_j" algoitem="MATIERE_j EST_DU_TYPE NOMBRE"/>
        <item code="1#LISTE#TAB" algoitem="TAB EST_DU_TYPE LISTE"/>
        <item code="1#NOMBRE#N" algoitem="N EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#M" algoitem="M EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#NOTE" algoitem="NOTE EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#N#3#pasliste" algoitem="N PREND_LA_VALEUR 3"/>
        <item code="5#M#3#pasliste" algoitem="M PREND_LA_VALEUR 3"/>
        <item code="12#ETUDIANT_i#1#N" algoitem="POUR ETUDIANT_i ALLANT_DE 1 A N">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="12#MATIERE_j#1#M" algoitem="POUR MATIERE_j ALLANT_DE 1 A M">
                <item code="13#debutpour" algoitem="DEBUT_POUR"/>
                <item code="4#NOTE DE L'ETUDIANT #0" algoitem="AFFICHER &quot;NOTE DE L'ETUDIANT &quot;"/>
                <item code="3#ETUDIANT_i#0#pasliste" algoitem="AFFICHER ETUDIANT_i"/>
                <item code="4#POUR MATIERE #0" algoitem="AFFICHER &quot;POUR MATIERE &quot;"/>
                <item code="3#MATIERE_j#0#pasliste" algoitem="AFFICHER MATIERE_j"/>
                <item code="2#NOTE#pasliste" algoitem="LIRE NOTE"/>
                <item code="5#TAB#NOTE#ETUDIANT_i, MATIERE_j" algoitem="TAB[ETUDIANT_i, MATIERE_j] PREND_LA_VALEUR NOTE"/>
                <item code="14#finpour" algoitem="FIN_POUR"/>
            </item>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="12#ETUDIANT_i#1#N" algoitem="POUR ETUDIANT_i ALLANT_DE 1 A N">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="4#   ///   #1" algoitem="AFFICHER &quot;   ///   &quot;"/>
            <item code="4#ETUDIANT #0" algoitem="AFFICHER &quot;ETUDIANT &quot;"/>
            <item code="3#ETUDIANT_i#0#pasliste" algoitem="AFFICHER ETUDIANT_i"/>
            <item code="4# : #1" algoitem="AFFICHER &quot; : &quot;"/>
            <item code="12#MATIERE_j#1#M" algoitem="POUR MATIERE_j ALLANT_DE 1 A M">
                <item code="13#debutpour" algoitem="DEBUT_POUR"/>
                <item code="4#MATIERE #0" algoitem="AFFICHER &quot;MATIERE &quot;"/>
                <item code="3#MATIERE_j#0#pasliste" algoitem="AFFICHER MATIERE_j"/>
                <item code="4# : #0" algoitem="AFFICHER &quot; : &quot;"/>
                <item code="3#TAB#1#ETUDIANT_i,MATIERE_j" algoitem="AFFICHER TAB[ETUDIANT_i,MATIERE_j]"/>
                <item code="14#finpour" algoitem="FIN_POUR"/>
            </item>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
