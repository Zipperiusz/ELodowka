using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ELodowka.Data.Common.Exceptions;

namespace ELodowka.Data;

public abstract class BaseRepository<TEntity>
    : IBaseRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public BaseRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<TEntity>> GetMany()
    {
        return _context.Set<TEntity>().ToListAsync();
    }

    public Task<List<TProjectTo>> GetMany<TProjectTo>()
    {
        return _context.Set<TEntity>().ProjectTo<TProjectTo>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<TEntity?> Get(long id)
    {
        return _context.Set<TEntity>().FirstOrDefaultAsync(entity => entity.Id == id);
    }

    public Task<TProjectTo?> Get<TProjectTo>(long id)
    {
        return _context.Users.Where(entity => entity.Id == id).ProjectTo<TProjectTo>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
    }

    public async Task<TEntity> Add(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task Delete(long id)
    {
        var entity = await _context.Users.Where(user => user.Id == id).FirstOrDefaultAsync();
        if (entity == null) throw new EntityNotFoundException();

        _context.Users.Remove(entity);
        await _context.SaveChangesAsync();
    }

    
}