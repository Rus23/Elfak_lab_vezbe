package com.javawebtutor.MyRegService;

import java.sql.Timestamp;
import java.util.Arrays;
import java.util.Calendar;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;

import javax.ejb.Remote;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;
import javax.persistence.criteria.CriteriaQuery;

import org.hibernate.Criteria;
import org.hibernate.HibernateException;
import org.hibernate.Query;
import org.hibernate.SQLQuery;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;
import org.hibernate.criterion.Restrictions;
import org.hibernate.service.ServiceRegistryBuilder;
import org.hibernate.service.internal.StandardServiceRegistryImpl;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

@Remote(IKorisnik_service.class)
@Stateless
public class korisnik_service implements IKorisnik_service {

	@Override
	public void zahtevaj_tehnicki_pregled(int id_zah_za_tp, int id_kor, int id_voz, int neispravan_deo, int vrsta_tp,
			int snaga_motora) {
		
		  EntityManager em;
		  EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		  em = emf.createEntityManager();
		  em.getTransaction().begin();
		  
		  zahtevi_za_tehnicki_pregled zahtev_tp = new zahtevi_za_tehnicki_pregled(id_zah_za_tp,id_kor,id_voz,neispravan_deo,vrsta_tp,snaga_motora);
		  em.persist(zahtev_tp);
		  em.getTransaction().commit();		
	}

	@Override
	public void zahtevaj_placanje(int id_zah_za_pla, int id_kor) {
		  EntityManager em;
		  EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		  em = emf.createEntityManager();
		  em.getTransaction().begin();
		  
		  Scanner scanner = new Scanner(System.in);
		  
		  for(obavezna_placanja obaveza: zahtevaj_obavezna_placanja(id_kor)){
			  String sta_se_placa = "Tehnicki pregled";
			  if(obaveza.getSta() == 1)
				  sta_se_placa = "Osiguranje";
			  else if(obaveza.getSta() == 2)
				  sta_se_placa = "Popravku";
			  
			  System.out.println("Cena za" + sta_se_placa + "je: " + obaveza.getCena());
				int nacin = 2;
				while(nacin != 0 || nacin != 1){
					System.out.print("Odaberite nacin placanja: ");
					System.out.print("- 0 = elektronskim putem ");
					System.out.print("- 1 = uplatom na bankovni racun");
					nacin = scanner.nextInt();
				}
			  System.out.print("Unesite koliko zelite da uplatite novca: ");
			  int uplata = scanner.nextInt();
			  
			  if(uplata != obaveza.getCena()){
				  System.out.println("Niste uneli odgovarajucu sumu novca");
				  zahtevaj_placanje(id_zah_za_pla, id_kor); // sve opet od pocetka za uplatu...
				  return;
			  }
			  else{
				  zahtevi_za_placanje zahtev_pla = new zahtevi_za_placanje(id_zah_za_pla,obaveza.getId_kor(),nacin,obaveza.getSta(),uplata);
				  em.persist(zahtev_pla);
				  em.getTransaction().commit();	 
			  }
		  }
	}

	@Override
	public List<obavezna_placanja> zahtevaj_obavezna_placanja(int id_kor) {
		  EntityManager em;
		  EntityManagerFactory emf = Persistence.createEntityManagerFactory("EmployeePU");
		  em = emf.createEntityManager();
		  em.getTransaction().begin();
		  
		  TypedQuery<obavezna_placanja> tQuery = em.createQuery("from obavezna_placanja where id_kor=:id_k", obavezna_placanja.class);
		  tQuery.setParameter("id_k", id_kor);
		  List<obavezna_placanja> sva_obavezna_placanja = tQuery.getResultList();
		  
		  return sva_obavezna_placanja;
		
	}

}
