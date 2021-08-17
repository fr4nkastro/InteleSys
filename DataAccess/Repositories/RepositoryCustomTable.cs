using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
namespace DataAccess.Repositories
{
    public class RepositoryCustomTable
    {
        Repository<CustomTable> repository;
        string query, query2;
        public RepositoryCustomTable()
        {
            repository= new Repository<CustomTable>();
            query = @"SELECT a.descripcion AS 'Avería', MODELO.nombre + '-'+ m.serialno AS 'Máquina' FROM AVERIAS AS a
                    JOIN
                    (SELECT * FROM REGISTRO_AVERIA WHERE mantenimiento_id = 1000001) AS rA
                    ON a.id = rA.averia_id
                    JOIN(SELECT articulo_id, serialno, modelo_id FROM MAQUINA) AS m
                    ON m.articulo_id = rA.maquina_id
                    JOIN MODELO
                    ON MODELO.id = m.modelo_id; ";
            query2 = @"SELECT a.descripcion AS 'Avería', a.solucion AS 'Solución', MODELO.nombre + '-'+ m.serialno AS 'Máquina' FROM AVERIAS AS a
                    JOIN
                    (SELECT * FROM REGISTRO_AVERIA WHERE mantenimiento_id=1000001) AS rA
                    ON a.id= rA.averia_id
                    JOIN (SELECT articulo_id, serialno,modelo_id FROM MAQUINA) AS m
                    ON m.articulo_id= rA.maquina_id
                    JOIN MODELO
                    ON MODELO.id= m.modelo_id;";
        }
        public IEnumerable<CustomTable> GetAll()
        {
            return repository.ExecuteQuery(query2);


        }
    }
}
