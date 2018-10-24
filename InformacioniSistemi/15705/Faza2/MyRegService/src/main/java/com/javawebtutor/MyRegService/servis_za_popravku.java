package com.javawebtutor.MyRegService;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import javax.persistence.TypedQuery;

public class servis_za_popravku implements IServis_za_popravku{

	@Override
	public void ispitaj_vozila() {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		TypedQuery<obradjeni_zahtevi> tQuery = em.createQuery("from obradjeni_zahtevi where neispravan_deo>0", obradjeni_zahtevi.class);
		List<obradjeni_zahtevi> neispravna_vozila = tQuery.getResultList();
		
		for(obradjeni_zahtevi vozilo : neispravna_vozila){
			
			int id_oba_pla = (int)(Math.random() * 1000000); // ne znam da li ce MySQL baza auto-incrementalno da dodeljuje ID-jeve, paa nek bude ovako....
			int sta = 2; // sta = 2 = popravka, sta = 0 = tehnicki pregled , sta = 1 = osiguranje
			
			//popravi_vozilo vraca deo koji je porpavljen i upisuje u tebelu obradjeni_zahtevi 
			cene_popravke cena_stete = proceni_stetu(popravi_vozilo(vozilo.getId_voz()));
			vrati_cenu_popravke(id_oba_pla,vozilo.getId_kor(),sta,cena_stete.getCena()); // upisuje u tabelu obavezna_placanja			
		}
	}

	@Override
	public int popravi_vozilo(int id_voz) {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		TypedQuery<obradjeni_zahtevi> obr_zah_upit = em.createQuery("from obradjeni_zahtevi where id_voz=:id_voz",obradjeni_zahtevi.class);
		obr_zah_upit.setParameter("id_voz", id_voz);
		obradjeni_zahtevi zahtev = obr_zah_upit.getSingleResult();
		
		int popravljeni_deo = zahtev.getNeispravan_deo();
		
		obradjeni_zahtevi zahtev_za_azuriranje = em.find(obradjeni_zahtevi.class,zahtev.getId_obr_zah() );
		zahtev_za_azuriranje.setNeispravan_deo(0);
		zahtev_za_azuriranje.setUspesno(1);
		
		System.out.println("Vozilo je popravljeno");
		
		em.getTransaction().commit();
		
		return popravljeni_deo;
	}

	@Override
	public cene_popravke proceni_stetu(int neispravan_deo) {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		TypedQuery<cene_popravke> cena_popravke_upit = em.createQuery("from cene_popravke where neispravan_deo=:neispravan_deo ", cene_popravke.class);
		cena_popravke_upit.setParameter("neispravan_deo", neispravan_deo);
		
		
		return cena_popravke_upit.getSingleResult();
	}

	@Override
	public void vrati_cenu_popravke(int id_oba_pla, int id_kor, int sta, int cena) {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		obavezna_placanja obaveza = new obavezna_placanja(id_oba_pla,id_kor,sta,cena);
		em.persist(obaveza);
		em.getTransaction().commit();
	}

}
