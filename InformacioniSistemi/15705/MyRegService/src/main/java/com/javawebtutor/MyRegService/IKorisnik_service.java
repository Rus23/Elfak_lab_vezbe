package com.javawebtutor.MyRegService;

import java.util.List;

public interface IKorisnik_service {

	void zahtevaj_tehnicki_pregled(int id_zah_za_tp, int id_kor, int id_voz, int neispravan_deo, int vrsta_tp, int snaga_motora);
	void zahtevaj_placanje(int id_zah_za_pla, int id_kor);
	List<obavezna_placanja> zahtevaj_obavezna_placanja(int id_kor);// vraca sva obavezna placanje za korisnika iz tabele obavezna_placanja
	
}
