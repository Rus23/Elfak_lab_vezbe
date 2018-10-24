package com.javawebtutor.MyRegService;

public interface IServis_za_tehnicki_pregled {

	void proveri_zahteve(); //cita zahtev iz tabele zahtevi_za_tehnicki_pregled i upisuje obradjen zahtev u obradjeni_zahtevi
	void naplati_uslugu(int id_kor, int vrsta_tp, int snaga_motora); // ce da cita podatke o ceni iz cene_tp i cene_osiguranje, pa salje podatke za naplatu u tabeli obavezna_placanja 
}
