package com.javawebtutor.MyRegService;

public interface IServis_za_popravku {

	void ispitaj_vozila(); // ovo ce da cita tabelu obradjeni zahtevi i proverava koje vozilo nije ispravno
	int popravi_vozilo(int id_voz); // ovo ce da "popravi vozilo", vraca neispravan deo koji je popravio
	cene_popravke proceni_stetu(int neispravan_deo); // ovo ce da cita iz cene_popravke
	void vrati_cenu_popravke(int id_oba_pla, int id_kor, int sta, int cena); // ovo ce da upisuje u tabelu obavezna_placanja
}
