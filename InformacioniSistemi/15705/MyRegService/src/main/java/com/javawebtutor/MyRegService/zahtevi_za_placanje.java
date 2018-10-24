package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name ="zahtevi_za_placanje")
public class zahtevi_za_placanje {

	@Id
	@Column(name = "id_zah_za_pla")
	private int id_zah_za_pla;
	
	@Column(name = "id_kor")
	private int id_kor;
	
	@Column(name = "nacin")
	private int nacin;
	
	@Column(name = "sta")
	private int sta; // 0 = tp i Osigruanje, 1 = popravka
	
	@Column(name = "novac")
	private int novac;

	public zahtevi_za_placanje(int id_zah_za_pla, int id_kor, int nacin, int sta, int novac) {
		super();
		this.id_zah_za_pla = id_zah_za_pla;
		this.id_kor = id_kor;
		this.nacin = nacin;
		this.sta = sta;
		this.novac = novac;
	}
	
	public zahtevi_za_placanje(){
		
	}

	public int getId_zah_za_pla() {
		return id_zah_za_pla;
	}

	public void setId_zah_za_pla(int id_zah_za_pla) {
		this.id_zah_za_pla = id_zah_za_pla;
	}

	public int getId_kor() {
		return id_kor;
	}

	public void setId_kor(int id_kor) {
		this.id_kor = id_kor;
	}

	public int getNacin() {
		return nacin;
	}

	public void setNacin(int nacin) {
		this.nacin = nacin;
	}

	public int getSta() {
		return sta;
	}

	public void setSta(int sta) {
		this.sta = sta;
	}

	public int getNovac() {
		return novac;
	}

	public void setNovac(int novac) {
		this.novac = novac;
	}
	
}
