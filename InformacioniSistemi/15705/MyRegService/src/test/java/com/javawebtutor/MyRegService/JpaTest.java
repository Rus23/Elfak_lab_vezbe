package com.javawebtutor.MyRegService;

public class JpaTest {
	public static void main(String[] args){
		
		korisnik_service korisnik1 = new korisnik_service();
		korisnik_service korisnik2 = new korisnik_service();
		korisnik_service korisnik3 = new korisnik_service();
		
		servis_za_popravku servis_za_popravku = new servis_za_popravku();
		servis_za_registraciju servis_za_registraciju = new servis_za_registraciju();
		servis_za_tehnicki_pregled servis_za_tehnicki_pregled = new servis_za_tehnicki_pregled();
		
		int id_zah_za_tp = 0;
		int id_kor = 0;
		int id_voz = 0;
		int neispravan_deo = 3;
		int vrsta_tp = 1;
		int snaga_motora = 23;
		
		korisnik1.zahtevaj_tehnicki_pregled(id_zah_za_tp++, id_kor++, id_voz++, neispravan_deo++, vrsta_tp++, snaga_motora);

		korisnik2.zahtevaj_tehnicki_pregled(id_zah_za_tp++, id_kor++, id_voz++, neispravan_deo++, vrsta_tp++, snaga_motora+10);
		korisnik3.zahtevaj_tehnicki_pregled(id_zah_za_tp, id_kor, id_voz, neispravan_deo, vrsta_tp, snaga_motora+20);
		
		servis_za_tehnicki_pregled.proveri_zahteve(); // zovi naplati_uslugu
		servis_za_popravku.ispitaj_vozila();// zove popravi_vozilo i vrati_cenu_popravke
		servis_za_registraciju.prihvati_zahteve(); // zove upisi_novu_registraciju , a upisi_novu_registraciju zove obrisi_istekle_registracije
		
		
		
	}
}
