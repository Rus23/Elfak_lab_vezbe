package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="obradjeni_zahtevi")
public class obradjeni_zahtevi {

	@Id
	@Column(name="id_obr_zah")
	private int id_obr_zah;
	
	@Column(name="id_kor")
	private int id_kor;
	
	@Column(name="uspesno")
	private int uspesno;
	
	@Column(name="id_voz")
	private int id_voz;
	
	@Column(name="neispravan_deo")
	private int neispravan_deo;

	public obradjeni_zahtevi(int id_obr_zah, int id_kor, int uspesno, int id_voz, int neispravan_deo) {
		super();
		this.id_obr_zah = id_obr_zah;
		this.id_kor = id_kor;
		this.uspesno = uspesno;
		this.id_voz = id_voz;
		this.neispravan_deo = neispravan_deo;
	}
	
	public obradjeni_zahtevi(){
		
	}

	public int getId_obr_zah() {
		return id_obr_zah;
	}

	public void setId_obr_zah(int id_obr_zah) {
		this.id_obr_zah = id_obr_zah;
	}

	public int getId_kor() {
		return id_kor;
	}

	public void setId_kor(int id_kor) {
		this.id_kor = id_kor;
	}

	public int getUspesno() {
		return uspesno;
	}

	public void setUspesno(int uspesno) {
		this.uspesno = uspesno;
	}

	public int getId_voz() {
		return id_voz;
	}

	public void setId_voz(int id_voz) {
		this.id_voz = id_voz;
	}

	public int getNeispravan_deo() {
		return neispravan_deo;
	}

	public void setNeispravan_deo(int neispravan_deo) {
		this.neispravan_deo = neispravan_deo;
	}
	
	
}
