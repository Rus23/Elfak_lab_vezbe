package com.javawebtutor.MyRegService;


import java.util.Calendar;
import java.util.Date;
import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.TypedQuery;

public class servis_za_registraciju implements IServis_za_registraciju{

	@Override
	public void prihvati_zahteve() {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		TypedQuery<obradjeni_zahtevi> zahtevi_upit = em.createQuery("from obradjeni_zahtevi where uspesno=1",obradjeni_zahtevi.class);
		List<obradjeni_zahtevi> zahtevi = zahtevi_upit.getResultList();
		
		for(obradjeni_zahtevi zahtev : zahtevi){
			
			TypedQuery<obavezna_placanja> obaveze_upit = em.createQuery("from obavezna_placanja where id_kor=:id_kor",obavezna_placanja.class);
			obaveze_upit.setParameter("id_kor", zahtev.getId_kor());
			List<obavezna_placanja> obaveze = obaveze_upit.getResultList();
			
			TypedQuery<zahtevi_za_placanje> uplate_upit = em.createQuery("from zahtevi_za_placanje where id_kor=:id_kor",zahtevi_za_placanje.class);
			uplate_upit.setParameter("id_kor", zahtev.getId_kor());
			List<zahtevi_za_placanje> uplate = uplate_upit.getResultList();
			
			int br_poklapanja = 0;
			if(obaveze.size() == uplate.size()){
				for(obavezna_placanja obaveza : obaveze)
					for(zahtevi_za_placanje uplata: uplate)
						br_poklapanja += obaveza.getSta() == uplata.getSta() && obaveza.getCena() == uplata.getNovac() ? 1 : 0;
				
				if(br_poklapanja == obaveze.size()){
					int id_usp_reg = (int)(Math.random()*1000000);
					upisi_novu_registraciju_u_bazu(id_usp_reg,zahtev.getId_kor(),zahtev.getId_voz());
					
				}
			}
		}
	}

	@Override
	public void upisi_novu_registraciju_u_bazu(int id_usp_reg, int id_kor, int id_voz) {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		Calendar cal = Calendar.getInstance();
		cal.add(Calendar.YEAR, 1); 
		Date rok_zavrsetka = cal.getTime();
		
		obrisi_istekle_registracije();
		
		uspesne_registracije registracija = new uspesne_registracije(id_usp_reg, id_kor, id_voz, rok_zavrsetka);
		em.persist(registracija);
		em.getTransaction().commit();
	}

	@Override
	public void obrisi_istekle_registracije() {
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		
		Calendar cal = Calendar.getInstance();
		Date danas = cal.getTime();
		
		TypedQuery<uspesne_registracije> istekle_reg_upit = em.createQuery("from uspesne_registracje where rok_zavrsetka=:danas",uspesne_registracije.class);
		istekle_reg_upit.setParameter("danas", danas);
		List<uspesne_registracije> istekle_reg = istekle_reg_upit.getResultList();
		
		for(uspesne_registracije reg : istekle_reg){
			reg = em.find(uspesne_registracije.class, reg.getId_usp_reg());
			em.remove(reg);
			em.getTransaction().commit();
		}
		
	}

}








