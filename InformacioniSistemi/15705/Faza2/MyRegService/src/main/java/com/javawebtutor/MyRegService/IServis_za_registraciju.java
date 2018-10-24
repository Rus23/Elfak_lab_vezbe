package com.javawebtutor.MyRegService;

public interface IServis_za_registraciju {

	void prihvati_zahteve(); // citace iz tabele obavezna_placanja, zahtevi_za_placanja i obradjeni_zahtevi, i proveravace poklapanja
	void upisi_novu_registraciju_u_bazu(int id_usp_reg, int id_kor, int id_voz);
	void obrisi_istekle_registracije(); 
}
