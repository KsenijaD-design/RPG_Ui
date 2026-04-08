# RPG UI Anomalous battle
#### UI RPG spēle, kas notiek pēc radioaktīvā spārdziena. 

## OOP principi

+ **Mantošana** - tika ieviestas bāzes klasēs kā *character.cs, Weapon.cs, enemy.cs*, lai no tiem varētu mantot citi klases tipi kā dažāda veida personāži, monstri un ieroči. Tika izmantots, lai nedublēt kodu. 

+ **Enkapsulācija** - ir aizsargāti properties. 

+ **Polimorfisms** - overload - tika izmantots ienaidnieku uzbrukumam *GameManager.cs*. Override - tika izmantots ieroču bojājumu aprēķinos, jo katram ieročim ir override metode *GetDamage()*. 

+ **Abstrakcija** - tika definētas 3 abstraktas klases - *character.cs, Weapon.cs un enemy.cs*, - tas definē visparīgas ieroča vai personāža īpašības un metodes. Ir obligātas abstractas metodes, kas katram mantošām klasēm jāimplementē. Piemērma, katram personāžam jāimplementē *Attack()* un *Die()*. Ieguvums ir tā, ka citas klases kā *GameManager.cs* var strādat ar visparīgu *Enemy* tipu. 

## Papilduzdevumi:

+ 3 dažādi ieroču tipi, kurus spēlētājs var izvēlēties.  

+ 3 dažādi pretinieki ar atšķirīģiem uzbrukumiem.

+ Ir iespēja ieslēgt izslēgt vairogu. Vairogs samazina saņemto sitienu spēku, taču pastāv varbūtība, ka tas tiks iznīcināts. 

+ Radošs papildinājums - grafiskie elementi katram ierocim, pretiniekam un vairogam. Tie pareizi iesledzās.
