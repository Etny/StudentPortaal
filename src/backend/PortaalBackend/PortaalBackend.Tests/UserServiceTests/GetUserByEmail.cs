namespace PortaalBackend.Tests.UserServiceTests
{
    [ExcludeFromCodeCoverage]
    public class GetUserByEmail
    {
        private readonly UserService userService;
        private readonly Mock<IRepository<User>> mockRepository;

        public GetUserByEmail()
        {
            mockRepository = new Mock<IRepository<User>>();
            userService = new UserService(mockRepository.Object);
        }

        [Fact]
        public void Should_Call_Repository()
        {
            // Arrange
            IQueryable<User> mockQueryable = new List<User>() { new() { Email = "Test" } }.AsQueryable();
            mockRepository.Setup(y => y.GetAll()).Returns(mockQueryable);

            // Act
            User answer = userService.GetUserByEmail("Test")!;

            // Assert
            mockRepository.Verify(y => y.GetAll(), Times.Once);
            Assert.Equal("Test", answer.Email);
        }

        [Fact]
        public void Should_Return_Null()
        {
            // Arrange
            IQueryable<User> mockQueryable = new List<User>() { new() { Email = "Test" } }.AsQueryable();
            mockRepository.Setup(y => y.GetAll()).Returns(mockQueryable);

            // Act
            User? answer = userService.GetUserByEmail("NOPE");

            // Assert
            Assert.Null(answer);
        }
    }
}
