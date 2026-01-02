# Contoso.Mail Makefile

.PHONY: help build test clean publish watch restore run

# Default target
help:
	@echo "Available targets:"
	@echo "  make build     - Build the project"
	@echo "  make test      - Run tests"
	@echo "  make clean     - Clean build artifacts"
	@echo "  make restore   - Restore NuGet packages"
	@echo "  make publish   - Publish the application"
	@echo "  make watch     - Run in watch mode"
	@echo "  make run       - Run the application"

# Restore NuGet packages
restore:
	dotnet restore Contoso.Mail.csproj

# Build the project
build:
	dotnet build Contoso.Mail.csproj --no-restore

# Run tests
test:
	dotnet test Contoso.Mail.csproj --no-build --verbosity normal

# Clean build artifacts
clean:
	dotnet clean Contoso.Mail.csproj
	rm -rf bin obj

# Publish the application
publish:
	dotnet publish Contoso.Mail.csproj --configuration Release --output ./publish

# Run in watch mode for development
watch:
	dotnet watch run --project Contoso.Mail.csproj

# Run the application
run:
	dotnet run --project Contoso.Mail.csproj
