package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="cene_tehnickog_pregleda")
public class cene_tehnickog_pregleda {

	@Id
	@Column(name = "id_cen_teh_pre")
	private int id_cen_teh_pre;
	
	@Column(name = "vrsta_tp")
	private int vrsta_tp;
	
	@Column(name = "cena")
	private int cena;
	
	@Column(name = "opis")
	private String opis;

	public cene_tehnickog_pregleda(int id_cen_teh_pre, int vrsta_tp, int cena, String opis) {
		super();
		this.id_cen_teh_pre = id_cen_teh_pre;
		this.vrsta_tp = vrsta_tp;
		this.cena = cena;
		this.opis = opis;
	}
	
	public cene_tehnickog_pregleda(){
		
	}

	public int getId_cen_teh_pre() {
		return id_cen_teh_pre;
	}

	public void setId_cen_teh_pre(int id_cen_teh_pre) {
		this.id_cen_teh_pre = id_cen_teh_pre;
	}

	public int getVrsta_tp() {
		return vrsta_tp;
	}

	public void setVrsta_tp(int vrsta_tp) {
		this.vrsta_tp = vrsta_tp;
	}

	public int getCena() {
		return cena;
	}

	public void setCena(int cena) {
		this.cena = cena;
	}

	public String getOpis() {
		return opis;
	}

	public void setOpis(String opis) {
		this.opis = opis;
	}
	
	
}
