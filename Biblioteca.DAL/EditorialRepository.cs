using Biblioteca.DAL.Interfaces;
using Biblioteca.Entities.Models;
using Dapper;

namespace Biblioteca.DAL
{
    public class EditorialRepository : IEditorialRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public EditorialRepository(IDatabaseRepository databaseRepository)
        {
            this.databaseRepository = databaseRepository;
        }

        public async Task<List<Editorial>> GetEditorialesAsync()
        {
            string query = "SELECT * FROM Editoriales";
            return await databaseRepository.GetDataByQueryAsync<Editorial>(query);
        }

        public async Task<Editorial> GetEditorialByIdAsync(int id)
        {
            string query = "SELECT * FROM Editoriales WHERE Id = @Id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return (await databaseRepository.GetDataByQueryAsync<Editorial>(query, parameters)).FirstOrDefault();
        }

        public async Task<int> InsertEditorialAsync(Editorial Editorial)
        {
            string query = "INSERT INTO Editoriales (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY()";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nombre", Editorial.Nombre);
            return await databaseRepository.InsertAsync(query, parameters);
        }

        public async Task<Editorial> UpdateEditorialAsync(Editorial Editorial)
        {
            string query = "UPDATE Editoriales SET Nombre = @Nombre WHERE Id = @Id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Editorial.Id);
            parameters.Add("@Nombre", Editorial.Nombre);
            await databaseRepository.UpdateAsync<Editorial>(query, parameters);
            return Editorial;
        }

        public async Task<bool> DeleteEditorialAsync(int id)
        {
            string query = "DELETE FROM Editoriales WHERE Id = @Id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return await databaseRepository.DeleteAsync(query, parameters);
        }
    }
}