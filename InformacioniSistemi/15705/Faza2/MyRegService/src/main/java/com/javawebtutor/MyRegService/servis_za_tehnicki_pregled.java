package com.javawebtutor.MyRegService;

import java.util.List;
import java.util.Scanner;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import javax.persistence.TypedQuery;

public class servis_za_tehnicki_pregled implements IServis_za_tehnicki_pregled{

	@Override
	public void proveri_zahteve() {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		TypedQuery<zahtevi_za_tehnicki_pregled> zahtevi_tp_upit = em.createQuery("from zahtevi_za_tehnicki_pregled", zahtevi_za_tehnicki_pregled.class);
		List<zahtevi_za_tehnicki_pregled> zahtevi_tp = zahtevi_tp_upit.getResultList();
		
		for(zahtevi_za_tehnicki_pregled zahtev_tp : zahtevi_tp){
			int id_obr_zah = (int)(Math.random() * 1000000);
					
			naplati_uslugu(zahtev_tp.getId_kor(),zahtev_tp.getVrsta_tp(),zahtev_tp.getSnaga_motora()); //procita cenu i posalje u obavezna_placanja
			
			int uspesno = zahtev_tp.getNeispravan_deo() == 0 ? 1 : 0;
			obradjeni_zahtevi obradjen_zahtev = new obradjeni_zahtevi(id_obr_zah, zahtev_tp.getId_kor(),uspesno,zahtev_tp.getId_voz(),zahtev_tp.getNeispravan_deo());
			em.persist(obradjen_zahtev);
			
			zahtev_tp = em.find(zahtevi_za_tehnicki_pregled.class, zahtev_tp.getId_zah_za_tp());
			em.remove(zahtev_tp);
			
			em.getTransaction().commit();
			em.close();
			emf.close();
		
		}
	}

	@Override
	public void naplati_uslugu(int id_kor, int vrsta_tp, int snaga_motora) {
		int id_zah_za_pla = (int)(Math.random() * 1000000);
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		TypedQuery<cene_tehnickog_pregleda> cena_tp_upit = em.createQuery("from cene_tehnickog_pregleda where vrsta_tp=:vrsta_tp",cene_tehnickog_pregleda.class);
		cena_tp_upit.setParameter("vrsta_tp", vrsta_tp);
		cene_tehnickog_pregleda cena_tp = cena_tp_upit.getSingleResult();

		System.out.println("Cena tehnickog pregleda(" + cena_tp.getOpis() + "): "+ cena_tp.getCena() +"RSD");
		int sta = 0; // sta = 0 = tehnicki pregled
		
		obavezna_placanja obaveza_tp = new obavezna_placanja(id_zah_za_pla,id_kor, sta, cena_tp.getCena());
		em.persist(obaveza_tp);
		
		
		TypedQuery<cene_osiguranja> cena_osiguranja_upit = em.createQuery("from cene_osiguranja where snaga_motora_donja_granica<=:snaga_motora and snaga_motora_gornja_granica >:snaga_motora",cene_osiguranja.class);
		cena_osiguranja_upit.setParameter("snaga_motora", snaga_motora);
		cene_osiguranja cena_osiguranja = cena_osiguranja_upit.getSingleResult();

		System.out.println("Cena osiguranja za snagu motora izmedju:"+ cena_osiguranja.getSnaga_motora_donja_granica() +" - "+cena_osiguranja.getSnaga_motora_gornja_granica() +"KW je: "+ cena_osiguranja.getCena() +"RSD");
		sta = 1; // sta = 1 = osiguranje
		
		obavezna_placanja obaveza_o = new obavezna_placanja(id_zah_za_pla+1, id_kor, sta, cena_osiguranja.getCena());
		em.persist(obaveza_o);
		
		em.getTransaction().commit();
		em.close();
		emf.close();

	}

}
