﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace esercizioS18L1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string LuogoDiNascita { get; set; }
        public string Residenza { get; set; }
        public string DataDiNascita { get; set; }
        public bool IsAzienda { get; set; }
        public string CodiceFiscale { get; set; } // Privato
        public string PartitaIVA { get; set; } // Azienda
        public string IndirizzoSede { get; set; } // Azienda
        public string CittaSede { get; set; } // Azienda


        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static List<Cliente> ListaClienti()
        {
            List<Cliente> clienti = new List<Cliente>();

            using (SqlConnection sqlConnection = new SqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Clienti";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                Id = (int)reader["Id"],
                                Nome = reader["Nome"].ToString(),
                                Cognome = reader["Cognome"].ToString(),
                                LuogoDiNascita = reader["LuogoDiNascita"].ToString(),
                                Residenza = reader["Residenza"].ToString(),
                                DataDiNascita = reader["DataDiNascita"].ToString(),
                                IsAzienda = (bool)reader["IsAzienda"],
                                CodiceFiscale = reader["CodiceFiscale"].ToString(),
                                PartitaIVA = reader["PartitaIVA"].ToString(),
                                IndirizzoSede = reader["IndirizzoSede"].ToString(),
                                CittaSede = reader["CittaSede"].ToString(),
                            };

                            clienti.Add(cliente);
                        }
                    }
                }
            }
            return clienti;
        }
    }

}