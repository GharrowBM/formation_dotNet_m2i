<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="DEBUT_FONCTION" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalBoucles="5000000" epaisseurPoint="2" epaisseurLigne="2" totalAffichages="1000" nbDecimales="8" maxBoucle="500000" arrondiAuto="vrai"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES">
        <item code="201#ShowNameNLast#NAME,LAST" algoitem="FONCTION ShowNameNLast(NAME,LAST)">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION">
                <item code="1#CHAINE#ShowNameNLast_MSG" algoitem="ShowNameNLast_MSG EST_DU_TYPE CHAINE"/>
            </item>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="5#ShowNameNLast_MSG#&quot;Votre nom est : &quot;+LAST+&quot; et votre prénom est : &quot;+NAME#pasliste" algoitem="ShowNameNLast_MSG PREND_LA_VALEUR &quot;Votre nom est : &quot;+LAST+&quot; et votre prénom est : &quot;+NAME"/>
            <item code="3#ShowNameNLast_MSG#0#pasliste" algoitem="AFFICHER ShowNameNLast_MSG"/>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
        <item code="201#AskFor#TEXT" algoitem="FONCTION AskFor(TEXT)">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION">
                <item code="1#CHAINE#AskFor_MSG" algoitem="AskFor_MSG EST_DU_TYPE CHAINE"/>
                <item code="1#CHAINE#AskFor_VAR" algoitem="AskFor_VAR EST_DU_TYPE CHAINE"/>
            </item>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="5#AskFor_MSG#&quot;Veuillez renseigner &quot;+TEXT+&quot; : &quot;#pasliste" algoitem="AskFor_MSG PREND_LA_VALEUR &quot;Veuillez renseigner &quot;+TEXT+&quot; : &quot;"/>
            <item code="3#AskFor_MSG#0#pasliste" algoitem="AFFICHER AskFor_MSG"/>
            <item code="2#AskFor_VAR#pasliste" algoitem="LIRE AskFor_VAR"/>
            <item code="205#AskFor_VAR" algoitem="RENVOYER AskFor_VAR"/>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
    </item>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#Uname" algoitem="Uname EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#Ulast" algoitem="Ulast EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#Ulast#AskFor(&quot;votre nom&quot;)#pasliste" algoitem="Ulast PREND_LA_VALEUR AskFor(&quot;votre nom&quot;)"/>
        <item code="5#Uname#AskFor(&quot;votre prenom&quot;)#pasliste" algoitem="Uname PREND_LA_VALEUR AskFor(&quot;votre prenom&quot;)"/>
        <item code="206#ShowNameNLast(Uname,Ulast)" algoitem="APPELER_FONCTION ShowNameNLast(Uname,Ulast)"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
