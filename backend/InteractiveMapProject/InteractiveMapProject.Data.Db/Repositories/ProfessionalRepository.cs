using System.IO;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Filtering;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Repositories;

public class ProfessionalRepository : Repository<Professional>, IProfessionalRepository
{
    private readonly DbSet<Professional> _professionals;
    private readonly IFilterFactory<Professional, ProfessionalFilterRequest> _filterFactory;

    public ProfessionalRepository(ApplicationDbContext dbContext,
        IFilterFactory<Professional, ProfessionalFilterRequest> filterFactory) : base(dbContext)
    {
        _professionals = dbContext.Set<Professional>();
        _filterFactory = filterFactory;
    }

    public new async Task<List<Professional>> GetAllAsync()
    {
        return await _professionals
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .ToListAsync();
    }

    private string[] ProfessionalToArray(Professional professional)
    {
        string[] professionalArray;
        if (professional.Description == null)
        {
            professionalArray = new string[]
            {
                professional.Name,
                professional.EstablishmentType,
                professional.ManagementType,
                professional.Address.Street,
                professional.Address.City,
                professional.Address.PostalCode,
                professional.PhoneNumber.ToString(),
                professional.Email,
                professional.ContactPerson.Name,
                professional.ContactPerson.Function,
                professional.ContactPerson.PhoneNumber.ToString(),
                professional.ContactPerson.Email
            };
        }
        professionalArray = new string[]
        {
            professional.Name,
            professional.EstablishmentType,
            professional.ManagementType,
            professional.Address.Street,
            professional.Address.City,
            professional.Address.PostalCode,
            professional.PhoneNumber.ToString(),
            professional.Email,
            professional.ContactPerson.Name,
            professional.ContactPerson.Function,
            professional.ContactPerson.PhoneNumber.ToString(),
            professional.ContactPerson.Email,
            professional.Description
        };

        return string.Join(" ", professionalArray).Split(' ');
    }

    private int GetNumberOfMatches(string[] professionalArray, string[] textArray)
    {
        int numberOfMatches = 0;
        foreach (string text in textArray)
        {
            if (professionalArray.Contains(text))
            {
                numberOfMatches++;
            }
        }
        return numberOfMatches;
    }

    public async Task<List<Professional>> GetAllAsync(ProfessionalFilterRequest filterRequest)
    {
        IQueryable<Professional> query = _professionals.AsQueryable();

        var filters = _filterFactory.BuildFilters(filterRequest);

        if (filters?.Any() == true)
        {
            query = filters.Aggregate(query, (current, item) => current.Where(item));
        }

        await query
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .ToListAsync();

        if (filterRequest.Text == null)
        {
            return query
                .ToList();
        }

        return query
            .ToList()
            .OrderByDescending(professional => GetNumberOfMatches(ProfessionalToArray(professional), filterRequest.Text.Split(" ")))
            .ToList();
    }

    public new async Task<Professional?> GetAsync(Guid id)
    {
        return await _professionals
            .Include(p => p.Audiences).ThenInclude(pa => pa.Audience)
            .Include(p => p.Missions).ThenInclude(pm => pm.Mission)
            .Include(p => p.PlacesOfIntervention).ThenInclude(pp => pp.PlaceOfIntervention)
            .SingleOrDefaultAsync(p => p.Id == id);
    }
}
