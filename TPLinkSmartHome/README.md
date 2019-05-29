---
Package: TPLinkSmartHome
Tags: TPLink, Plug
---

# TPLinkSmartHome : Prises et autres p�riph�riques connect�s

Le package TPLinkSmartHome vous permet de contr�ler et monitorer les p�riph�riques TPLink Smart Home (kasa smarthome).
**ATTENTION, pour le moment seules les prises HS100 et HS110 sont prises en charge par ce package.**

## Installation
Depuis le �Online Package Repository� de votre Console Constellation, installez et d�ployez le package sur la sentinelle de votre choix (compatible Windows et Linux).

Sur la page de Settings, vous devez obligatoirement d�finir un ou plusieurs p�riph�riques.

Par exemple : 
```json
	[{
        "HostName": "192.168.0.123",
        "Type": "PlugWithEnergyMeter"
        }, {
        "HostName": "192.168.0.234",
        "Type": "Plug"
    }]
```

Vous pouvez �galement d�ployer ce package manuellement dans la configuration de votre Constellation :
```xml
<package name="TPLinkSmartHome">
	<settings>
		<setting key="poolingInterval" value="2000" />
        <setting key="devices">
            <content>[{
			"HostName": "192.168.0.123",
			"Type": "PlugWithEnergyMeter"
		}, {
			"HostName": "192.168.0.234",
			"Type": "PlugWithEnergyMeter"
		}]</content>
		</setting>
	</settings>
</package>
```

## Settings

| Nom | Type | Requis ? | Description du Setting |
| --- | ---- | -------- | ---------------------  |
| devices | JsonObject | OUI | liste de p�riph�riques |
| poolingInterval | int | NON | interval en millisecondes entre deux r�cup�ration de l'�tat des p�riph�riques (d�faut : 2000ms) |

## StateObjects
Vous retrouverez 1 StateObject publi�s par p�riph�rique par le package :

| Nom | Type | Description |
| --- | ---- | ----------- |
| TPLink-<<Hostname>> | JsonObject | les informations d'un p�riph�rique |

## MessageCallbacks
Le package expose 3 MessageCallbacks :

| Signature | R�ponse (saga) | Description |
| --------- | -------------- | ----------- |
| GetDailyStat(string hostname, int? year = null, int? month = null) | JsonObject | Les statistiques d'utilisation quotidiennes pour une ann�e et un mois donn� (Pour les prises HS110 uniquement) |
| GetMonthStat(string hostname, int? year = null) | JsonObject | Les statistiques d'utilisation mensuelles pour une ann�e donn�e (Pour les prises HS110 uniquement) |
| SetOutputState(string hostname, bool state) : change l'�tat du relais (on/off) | Objet SunInfo | Change l'�tat d'une prise (Pour les prises HS100 et HS110 uniquement) |
  
## Quelques exemples
* Surveiller la consommation d'une prise connect�e
* Contr�ler � distance une prise connect�e, �teindre la nuit certaines prises etc.
  
License
----

Apache License
