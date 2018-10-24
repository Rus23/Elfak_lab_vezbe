package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="cene_poprvake")
public class cene_popravke {

	@Id
	@Column (name = "id_cen_pop")
	private int id_cen_pop;

	@Column (name = "neispravan_deo")
	private int neispravan_deo;

	@Column (name = "cena")
	private int cena;
	
	@Column (name = "opis")
	private int opis;

	public cene_popravke(int id_cen_pop, int neispravan_deo, int cena, int opis) {
		super();
		this.id_cen_pop = id_cen_pop;
		this.neispravan_deo = neispravan_deo;
		this.cena = cena;
		this.opis = opis;
	}
	public cene_popravke(){
		
	}
	public int getId_cen_pop() {
		return id_cen_pop;
	}

	public void setId_cen_pop(int id_cen_pop) {
		this.id_cen_pop = id_cen_pop;
	}

	public int getNeispravan_deo() {
		return neispravan_deo;
	}

	public void setNeispravan_deo(int neispravan_deo) {
		this.neispravan_deo = neispravan_deo;
	}

	public int getCena() {
		return cena;
	}

	public void setCena(int cena) {
		this.cena = cena;
	}

	public int getOpis() {
		return opis;
	}

	public void setOpis(int opis) {
		this.opis = opis;
	}
	
	
}
