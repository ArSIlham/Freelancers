using FreelancersProject.Domain.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Persistence.Repositories
{
	
        public class RoleStore : IRoleStore<Role>
        {
            private readonly string _connectionString;

            public RoleStore(IConfiguration configuration)
            {
                _connectionString = configuration.GetConnectionString("DefaultConnection");
            }

            public async Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(cancellationToken);
                    //role.Id = await connection.QuerySingleAsync<int>($@"INSERT INTO [Role] ([Name], [NormalizedName])
                    //VALUES (@{nameof(Role.Name)}, @{nameof(Role.NormalizedName)});
                    //SELECT CAST(SCOPE_IDENTITY() as int)", role);
                }

                return IdentityResult.Success;
            }

            public async Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(cancellationToken);
                    //await connection.ExecuteAsync($@"UPDATE [Role] SET
                    //[Name] = @{nameof(Role.Name)},
                    //[NormalizedName] = @{nameof(Role.NormalizedName)}
                    //WHERE [Id] = @{nameof(Role.Id)}", role);
                }

                return IdentityResult.Success;
            }

            public async Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(cancellationToken);
                    //await connection.ExecuteAsync($"DELETE FROM [Role] WHERE [Id] = @{nameof(Role.Id)}", role);
                }

                return IdentityResult.Success;
            }

            public Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken)
            {
                return Task.FromResult(role.Id.ToString());
            }

            public Task<string> GetRoleNameAsync(Role role, CancellationToken cancellationToken)
            {
                return Task.FromResult(role.Name);
            }

            public Task SetRoleNameAsync(Role role, string roleName, CancellationToken cancellationToken)
            {
                role.Name = roleName;
                return Task.FromResult(0);
            }

            public Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken)
            {
                return Task.FromResult(role.NormalizedName);
            }

            public Task SetNormalizedRoleNameAsync(Role role, string normalizedName, CancellationToken cancellationToken)
            {
                role.NormalizedName = normalizedName;
                return Task.FromResult(0);
            }

            public async Task<Role> FindByIdAsync(string roleId, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(cancellationToken);
                return null;
                //return await connection.QuerySingleOrDefaultAsync<Role>($@"SELECT * FROM [Role]
                //    WHERE [Id] = @{nameof(roleId)}", new { roleId });
                }
            }

            public async Task<Role> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(cancellationToken);
                return null;
                    //return await connection.QuerySingleOrDefaultAsync<Role>($@"SELECT * FROM [Role]
                    //WHERE [NormalizedName] = @{nameof(normalizedRoleName)}", new { normalizedRoleName });
                }
            }

            public void Dispose()
            {
                // Nothing to dispose.
            }
        }
    }

