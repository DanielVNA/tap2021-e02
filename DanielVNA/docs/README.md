# Principiile S.O.L.I.D. #

## S -> Single Resposability Principle ##
	~ Fiecare modul trebuie sa fie responsabil de un singur aspect al functionalitatii oferite de sistemul software
	~ In plus, acel aspect trebuie sa fie incapsulat in intregime de modulul responsabil

## O -> Open-Closed Principle ##
	~ Componentele unui sistem software trebuie sa fie usor de extins (deci deschise 'Open' la extinderi), dar greu de modificat (deci inchise 'Closed' la modificari)
	
## L -> Liskov Substitution Principle ##
	~ Componentele unui sistem software trebuie sa poata fi substituite de instante ale subtipurilor sale derivate
	~ Substitutia trebuie facuta astfel incat sa nu afecteze corectitudinea sistemului

## I -> Interface Segregation Principle ##
	~ Interfetele trebuie să fie mici si specifice contextului de utilizare, nu mari si generale

## D -> Dependency Inversion Principle ##
	~ Componentele unui sistem software trebuie sa depinda de reprezentari abstracte (interfete sau clase abstracte)
	~ Daca ar depinde de implementari concrete testarea si reimplementarea acelor componente ar fi dificila