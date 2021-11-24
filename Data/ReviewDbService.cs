using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class ReviewDbService
{
    #region Private members
    private ReviewDbContext dbContext;
    #endregion
    #region Constructor
    public ReviewDbService(ReviewDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of Reviews
    /// </summary>
    /// <returns></returns>
    public async Task<List<Review>> GetReviews()
    {
        return await dbContext.Review.ToListAsync();
    }
    /// <summary>
    /// This method add a new Review to the DbContext and saves it
    /// </summary>
    /// <param name="Review"></param>
    /// <returns></returns>
    public async Task<Review> AddReviewAsync(Review review)
    {
        try
        {
            dbContext.Review.Add(review);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return review;
    }
    /// <summary>
    /// This method update and existing Review and saves the changes
    /// </summary>
    /// <param name="Review"></param>
    /// <returns></returns>
    public async Task<Review> UpdateReviewAsync(Review review)
    {
        try
        {
            var ReviewExist = dbContext.Review.FirstOrDefault(p => p.ID == review.ID);
            if (ReviewExist != null)
            {
                dbContext.Update(review);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return review;
    }
    /// <summary>
    /// This method removes and existing Review from the DbContext and saves it
    /// </summary>
    /// <param name="Review"></param>
    /// <returns></returns>
    public async Task DeleteReviewAsync(Review review)
    {
        try
        {
            dbContext.Review.Remove(review);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}