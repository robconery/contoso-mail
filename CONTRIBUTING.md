# 🤝 Contributing to Contoso Mail

This project is part of the Atmosera GitHub training course. Follow these guidelines when contributing.

## 📋 Getting Started

1. Fork the repository to your GitHub account
2. Clone your fork locally:
   ```bash
   git clone https://github.com/YOUR-USERNAME/Contoso.Mail.git
   cd Contoso.Mail
   ```
3. Add the upstream repository:
   ```bash
   git remote add upstream https://github.com/ORIGINAL-OWNER/Contoso.Mail.git
   ```

## 🔄 Workflow

### Creating a Branch

Always create a new branch for your work:

```bash
git checkout -b feature/your-feature-name
```

Branch naming conventions:
- `feature/` - New features
- `fix/` - Bug fixes
- `docs/` - Documentation updates
- `test/` - Test additions or modifications

### Making Changes

1. Make your changes in your branch
2. Write or update tests as needed
3. Ensure all tests pass:
   ```bash
   make test
   ```
4. Build the project to verify:
   ```bash
   make build
   ```

### Committing

Write clear, descriptive commit messages:

```bash
git add .
git commit -m "Add contact filtering by email domain"
```

Good commit message format:
- Use present tense ("Add feature" not "Added feature")
- Be specific about what changed
- Reference issue numbers when applicable: "Fix #123: Resolve contact duplication"

### Pushing and Pull Requests

1. Push your branch to your fork:
   ```bash
   git push origin feature/your-feature-name
   ```

2. Go to GitHub and create a Pull Request from your fork to the upstream repository

3. Fill out the PR template with:
   - Description of changes
   - Any related issues
   - Screenshots (if UI changes)
   - Testing performed

## ✅ Pull Request Guidelines

- Ensure your code builds without errors
- All tests must pass
- Add tests for new functionality
- Update documentation if needed
- Keep PRs focused on a single feature or fix
- Respond to code review feedback promptly

## 🧪 Testing

All contributions should include appropriate tests:

```bash
# Run all tests
make test

# Run with detailed output
dotnet test --verbosity detailed
```

## 📝 Code Style

- Follow C# naming conventions
- Add XML documentation comments to public classes and methods
- Keep methods focused and concise
- Use meaningful variable names

## 🐛 Reporting Issues

When creating an issue:
- Use a clear, descriptive title
- Describe the expected vs actual behavior
- Include steps to reproduce
- Add relevant code samples or error messages
- Specify your environment (.NET version, OS)

## 💬 Code Review

All submissions require review:
- Be respectful and constructive
- Focus on the code, not the person
- Ask questions for clarification
- Suggest improvements with reasoning
- Approve when requirements are met

## 📚 Training Tips

This is a learning environment:
- Don't hesitate to ask questions
- Learn from code reviews
- Review others' pull requests
- Practice Git commands in a safe environment
- Experiment with different workflows

## 📞 Questions?

If you have questions about contributing, ask your instructor or open a discussion issue.

## 🎓 Learning Resources

- [GitHub Flow Guide](https://guides.github.com/introduction/flow/)
- [Writing Good Commit Messages](https://chris.beams.io/posts/git-commit/)
- [Pull Request Best Practices](https://github.blog/2015-01-21-how-to-write-the-perfect-pull-request/)
