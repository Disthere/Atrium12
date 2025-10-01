﻿namespace Atrium12.Application
{
    public interface IExternalSourceService
    {
        /// <summary>
        /// Создание вопроса.
        /// </summary>
        /// <param name="questionDto">DTO для создания вопроса.</param>
        /// <param name="cancellationToken">Токен отметы.</param>
        /// <returns>Результат работы метода - либо ID созданного вопроса, либо список ошибок.</returns>
        //Task<Result<Guid, Failure>> Create(CreateQuestionDto questionDto, CancellationToken cancellationToken);

        /// <summary>
        /// Добавление ответа на вопрос.
        /// </summary>
        /// <param name="questionId">ID вопроса.</param>
        /// <param name="addAnswerDto">DTO для добавления ответа на вопрос.</param>
        /// <param name="cancellationToken">Токен отметы.</param>
        /// <returns>Результат работы метода - либо ID созданного ответа, либо список ошибок.</returns>
        //Task<Result<Guid, Failure>> AddAnswer(Guid questionId, AddAnswerDto addAnswerDto, CancellationToken cancellationToken);
    }
}
