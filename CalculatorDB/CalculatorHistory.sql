CREATE TABLE [dbo].[CalculatorHistory]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [CalculationExpression] NVARCHAR(MAX) NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'CalculatorHistory',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Calculation expression with result value',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'CalculatorHistory',
    @level2type = N'COLUMN',
    @level2name = 'CalculationExpression'