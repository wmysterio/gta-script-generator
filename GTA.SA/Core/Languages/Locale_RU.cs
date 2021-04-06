namespace GTA.Core.Languages {
    internal sealed class Locale_RU : Localization {
        internal Locale_RU() : base() {
            WordError = "Ошибка";

            #region GXT
            start_save_fxt = "Сохраняю FXT-архивы...";
            gxt_non_encoding_format = "Не указана кодировка!";
            gxt_bad_key_name_format = "GXT-ключ '{0}' указан неправильно!";
            gxt_exist_key_format = "GXT-ключ '{0}' уже добавлен ранее!";
            gxt_key_added_format = "GXT-ключ '{0}' добавлен...";
            gxt_encoding_not_chars_format = "В классе '{0}' не указаны символы конвертации!";
            gxt_encoding_non_equal_lenght_format = "В классе '{0}' разный набор символов!";
            gxt_incorrect_fxt_file_name = "Неправильное имя FXT-файла {0}!";
            #endregion

            #region GENERATOR
            start_generator = "Начинаю работу...";
            start_save_script_code = "Сохраняю код скрипта...";
            script_start_format = "[{0}] Старт...";
            script_end_format = "[{0}] Финиш...";
            generator_done_format = "Готово! Затрачено {0} с.";
            throw_error_info_format = "\nФайл: {0}\nМетод: {1}\nСтрока: {2}\nКолонка: {3}";
            temp_file_deleted_format = "Временный файл '{0}' удалён...";
            folder_not_found_format = "Папка '{0}' не определена!";
            folder_and_sanny_not_found_format = "Папка для '{0}' не определена!";
            start_compile = "Начинаю компиляцию...";
            start_sanny_builder = "Запускаю Sanny Builder...";
            compiling_done = "Компиляция завершена!";
            sanny_compile_error_format = "Ошибка компиляции! См. информацию в файле '{0}' в корне проекта.";
            file_not_found_format = "Файл '{0}' не найден!";
            script_img_not_replaced = "Не удалось перезаписать файл 'script.img'! Полностью выйдите из игры перед компиляцией.";
            #endregion

            #region THREAD, MISSIONS, EXTERNALS, FUNCTIONS
            thread_main_not_found_format = "Поток 'MAIN' отсутствует!";
            bad_thread_name_length_format = "Имя скрипта '{0}' должно быть от 1 до 7 символов!";
            bad_thread_name_format = "Неправильно указано имя скрипта '{0}'! Используйте только латинские символы, числа и знак _!";
            bad_function_name_format = "Неправильно указано имя функции '{0}'! Используйте только латинские символы, числа и знак _!";
            thread_not_found_format = "Поток '{0}' не найден!";
            mission_not_found_format = "Миссия '{0}' не найдена!";
            external_not_found_format = "Внешний скрипт '{0}' не найден!";
            overflow_missions = "Превышен лимит на количество миссий! Максимальное количество: 200 для SA или 120 для III и VC!";
            overflow_externals = "Превышен лимит на количество внешних скриптов! Максимальное количество: 82!";
            jump_table_not_handler_format = "Таблица переходов не имеет обработчика!";
            jump_table_none_cases_format = "Таблица переходов должна иметь минимум 1 метку!";
            jump_table_overflow_cases_format = "Таблица переходов должна иметь максимум 74 метки!";
            switch_exist_case_value_format = "Значение '{0}' уже существует в таблице переходов!";
            #endregion

            #region VARIABLES, PARAMETERS, LABELS
            variable_without_context_format = "Переменная '{0}' должна иметь контекст!";
            variable_unsupport_type_format = "Тип переменной '{0}' не поддерживается для этой операции!";
            variables_without_context_format = "Переменные '{0}' и '{1}' без контекста!";
            variable_is_not_parameter_format = "Переменная '{0}' не может быть параметром!";
            variable_overflow_size_format = "Переменная '{0}' занимает больше места, чем позволено!";
            string_incorrect_index = "Переменная '{0}' не может использовать индекс '{1}'!";
            incorrect_sstring_lenght_format = "Длина строки '{0}' должна быть до 7 символов включительно!";
            parameters_count_is_zero_format = "Количество параметров для метода '{0}' должно быть больше 0!";
            parameters_overflow_count_format = "Максимальное количество параметров для метода '{0}' должно быть {1}!";
            label_memory_not_found_format = "Не удалось найти метку '{0}'!";
            label_not_exist_format = "Метка не существует в методе '{0}'!";
            use_variable_as_static_only = "Глобальная перменная '{0}' должна быть объявлена с модификатором 'static'!";
            #endregion

            #region PANELS
            panel_incorrect_rows_count_format = "Панель '{0}' должна иметь от 1 до 12 строк включительно!";
            panel_array_dimenstion_not_2_format = "Массив '{0}' должен быть двумерным!";
            panel_rows_low_1_format = "Число строк в массиве '{0}' должно быть больше 1!";
            panel_rows_great_12_format = "Число строк в массиве '{0}' должно быть меньше 13!";
            panel_need_array_format = "Нужно указать массив!";
            panel_element_count_must_be_from_1_to_12_format = "Количество элементов в массиве '{0}' должно быть от 1 до 12 включительно!";
            #endregion

            #region ARRAYS
            max_index_of_array_overflow_format = "Максимальный индекс массива: {0}!";
            min_index_of_array_must_be_format = "Минимальное количество элементов массива: 1!";
            array_element_count_overflow_format = "Превышено количество элементов в массиве или его начальный индекс не позволяет создать больше элементов!";
            dont_use_array_element_as_array_index_format = "Переменную '{0}' нельзя использовать в качестве индекса массива!";
            array_element_must_be_global_with_type = "Массив '{0}' с типом '{1}' должен быть глобальным!";
            array_element_created_only_in_autoinitialize = $"Массив должен инициализироваться как поле класса!";
            array_indexes_have_32_and_33 = "Элементы массива не могут использовать переменные 32@ и 33@. Пожалуйста, укажите правильный индекс!";
            #endregion

            #region LIMITS
            bad_bit_format = "Бит числа должен быть от 0 до 31 включительно!";
            bits_work_in_sa_game_format = "Биты работают только в игре GTA SA!";
            method_used_in_mission_only_format = "Метод '{0}' можно использовать только в миссиях!";
            use_type_in_sa_game_only_format = "Тип '{0}' можно использовать только в GTA SA!";
            car_park_vehicle_not_parking = "Транспорт '{0}' не является парковочным!";
            conditions_count_is_zero_format = "Количество условий должно быть больше 0!";
            conditions_overflow_count_format = "Количество условий должно быть от 1 до 8!";
            car_park_count_overflow = "Максимальное количество транспорта на парковке равно {0}!";
            loop_for_step_low_format = "Шаг цикла должен быть больше 0!";
            loop_for_parameter_must_be_great_format = "Параметр цикла '{0}' должен быть больше за параметр '{1}'!";
            #endregion

            #region PLUGINS
            plugin_must_be_once_format = "Плагин '{0}' должен создаваться только один раз!";
            plugin_created_in_non_thread_format = "Плагин '{0}' должен создаваться в потоке!";
            plugin_created_in_main_trhead_format = "Плагин '{0}' не должен создаваться в потоке 'MAIN'!";
            plugin_must_created_in_main_trhead_format = "Плагин '{0}' должен создаваться в потоке 'MAIN'!";
            plugin_incorrect_params_method_format = "В методе '{0}' плагина '{1}' некорректные параметры!";
            plugin_overflow_audiotracks_format = "В методе '{0}' плагина '{1}' больше нет звуков для воспроизведения!";
            plugin_created_in_non_mission_format = "Плагин '{0}' должен создаваться в миссии!";
            plugin_created_in_custom_mission_format = "Плагин '{0}' нельзя создавать в произвольных миссиях!";
            plugin_overflow_cars_count_format = "В плагине '{0}' максимальное количество машин должно быть {1}!";
            plugin_need_min_cars_count_format = "В плагине '{0}' минимальное количество машин должно быть {1}!";
            plugin_need_player_car_format = "Плагин '{0}' должен иметь машину игрока!";
            plugin_need_points_from_1_to_99_format = "Плагин '{0}' должен иметь от 1 до 99 точек!";
            plugin_laps_count_from_2_to_99_format = "В плагине '{0}' должно быть от 2 до 99 кругов!";
            plugin_need_points_from_2_to_99_format = "Плагин '{0}' должен иметь от 2 до 99 точек!";
            plugin_not_have_missions_format = "В плагине '{0}' не добавлены миссии для запуска!";
            plugin_incorrect_andler = "В плагине '{0}' не задан обработчик '{1}'!";
            plugin_phone_not_have_dialog = "В плагине '{0}' не добавлены звонки!";
            plugin_have_ring_id = "В плагине '{0}' уже добавлен звонок с ID '{1}'!";
            plugin_cellphone_replicas_overflow = "Количество реплик в плагине '{0}' с ID звонка '{1}' превышает '{2}' или равно 0!";
            plugin_not_have_ring_id = "В плагине '{0}' не добавлен звонок с ID '{1}'!";
            plugin_overflow_count_of_properties_or_zero = "В плагине '{0}' количество недвижимости превышает '{1}' или равно 0!";
            plugin_price_of_properties_must_be_great_zero = "В плагине '{0}' цела недвижимости должна быть больше 0!";
            plugin_need_set_camera_position_in_property = "В плагине '{0}' не установлена позиция камеры!";
            plugin_overflow_count_of_save_points_or_zero = "В плагине '{0}' количество точек превышает '{1}' или равно 0!";
            plugin_need_default_mode_in_properies_and_save_game = "В плагине '{0}' ссылка на плагин '{1}' отсутствует или его настройки произвольны!";
            plugin_calculator_has_incorrect_expression = "В плагине '{0}' метод '{1}' имеет неправильный формат выражения!";
            #endregion

        }
    }
}