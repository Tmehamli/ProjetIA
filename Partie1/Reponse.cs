﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reponse
{
    public int IdReponse { get; set; }

    public int IdQuestion { get; set; }
	public virtual string Contenu
	{
		get;
		set;
	}

    public Reponse()
	{
	}

	public Reponse(int idReponse, int idQuestion, string contenu)
	{
        this.IdReponse = idReponse;
        this.IdQuestion = idQuestion;
        this.Contenu = contenu;
	}

}
