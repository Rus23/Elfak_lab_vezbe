package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name ="cene_osiguranja")
public class cene_osiguranja {

	@Id
	@Column(name = "id_cen_osi")
	private int id_cen_osi;
	
	@Column(name ="snaga_motora_donja_granica")
	private int snaga_motora_donja_granica;
	
	@Column(name ="snaga_motora_gornja_granica")
	private int snaga_motora_gornja_granica;
	
	@Column(name ="cena")
	private int cena;
	
	@Column(name ="opis")
	private String opis;
	
	public cene_osiguranja(){}
	
	public cene_osiguranja(int id_cen_osi, int snaga_motora_donja_granica,int snaga_motora_gornja_granica, int cena, String opis){
		this.id_cen_osi = id_cen_osi;
		this.snaga_motora_donja_granica = snaga_motora_donja_granica;
		this.snaga_motora_gornja_granica = snaga_motora_gornja_granica;
		this.cena = cena;
		this.opis = opis;
	}
	
	
	public int getId_cen_osi() {
		return id_cen_osi;
	}

	public void setId_cen_osi(int id_cen_osi) {
		this.id_cen_osi = id_cen_osi;
	}

	public int getSnaga_motora_donja_granica() {
		return snaga_motora_donja_granica;
	}

	public void setSnaga_motora_donja_granica(int snaga_motora_donja_granica) {
		this.snaga_motora_donja_granica = snaga_motora_donja_granica;
	}
	
	public int getSnaga_motora_gornja_granica() {
		return snaga_motora_gornja_granica;
	}

	public void setSnaga_motora_gornja_granica(int snaga_motora_gornja_granica) {
		this.snaga_motora_gornja_granica = snaga_motora_gornja_granica;
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
