﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Этот класс создан автоматически классом StronglyTypedResourceBuilder
    'с помощью такого средства, как ResGen или Visual Studio.
    'Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    'с параметром /str или перестройте свой проект VS.
    '''<summary>
    '''  Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ESModCreator__Remastered.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Перезаписывает свойство CurrentUICulture текущего потока для всех
        '''  обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на     play ambience ambience_boat_station_day
        '''    play ambience ambience_boat_station_night
        '''    play ambience ambience_camp_center_day
        '''    play ambience ambience_camp_center_evening
        '''    play ambience ambience_camp_center_night
        '''    play ambience ambience_camp_entrance_day
        '''    play ambience ambience_camp_entrance_evening
        '''    play ambience ambience_camp_entrance_day_people
        '''    play ambience ambience_camp_entrance_night
        '''    play ambience ambience_catacombs
        '''    play ambience ambience_catacombs_stones
        '''    play ambi [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property ambience() As String
            Get
                Return ResourceManager.GetString("ambience", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на     scene bg black
        '''    scene bg bus_stop
        '''    scene bg ext_aidpost_day
        '''    scene bg ext_aidpost_night
        '''    scene bg ext_aidpost_sunset
        '''    scene bg ext_bathhouse_night
        '''    scene bg ext_beach_day
        '''    scene bg ext_beach_night
        '''    scene bg ext_beach_sunset
        '''    scene bg ext_boathouse_day
        '''    scene bg ext_boathouse_night
        '''    scene bg ext_boathouse_sunset
        '''    scene bg ext_bus
        '''    scene bg ext_bus_night
        '''    scene bg ext_camp_entrance_day
        '''    scene bg ext_camp_entrance_night
        '''    scene bg ext_camp_entrance_sunset
        '''     [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property bg() As String
            Get
                Return ResourceManager.GetString("bg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на     show cg d1_food_normal
        '''    show cg d1_food_skolop
        '''    show cg d1_grasshopper
        '''    show cg d1_rena_sunset
        '''    show cg d1_rowrow
        '''    show cg d1_sl_dinner
        '''    show cg d1_sl_dinner_0
        '''    show cg d1_uv
        '''    show cg d1_uv_2
        '''    show cg d1_uvao_bus
        '''    show cg d2_2ch_beach
        '''    show cg d2_dv_guitar
        '''    show cg d2_lineup
        '''    show cg d2_micu_lib
        '''    show cg d2_miku_piano
        '''    show cg d2_miku_piano2
        '''    show cg d2_mirror
        '''    show cg d2_mt_undressed
        '''    show cg d2_mt_undressed_2
        '''    show cg d2_slavy [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property cg() As String
            Get
                Return ResourceManager.GetString("cg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на init:
        '''    $ mods[&quot;ESModCreator&quot;] = u&quot;ESModCreator&quot;
        '''label &lt;ESModCreator&gt;:
        '''    play music music_list[&quot;lets_be_friends&quot;]
        '''    scene bg ext_beach_night
        '''    th &quot;Здравствуй, для того, чтобы начать писать мод тебе требуется запустить ESModCreator.exe&quot; # ГГ думает
        '''    th &quot;Он находится относительно места установки Steam в \steamapps\workshop\content\331470\2013143922\&quot; # ГГ думает
        '''    th &quot;Благодарю за загрузку моего мода, не забывайте писать об ошибках и предлагать улучшения :)&quot;
        '''    scene bg semen_room with d [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property codex() As String
            Get
                Return ResourceManager.GetString("codex", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на label &lt;название блока&gt;:
        '''    jump # переход к блоку по названию
        '''    call # переход к блоку с возвратом
        '''init: # объявляем переменные
        '''    stop ambience # остановить проигрывание звука
        '''    image &lt;&gt; = &lt;&gt; # задать изображение в блоке init
        '''    return
        '''    with dspr # задержка 0.2 с
        '''    with dissolve # задержка 1 с
        '''    .
        '''</summary>
        Friend ReadOnly Property commands() As String
            Get
                Return ResourceManager.GetString("commands", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на     play music music_list[&quot;a_promise_from_distant_days&quot;]
        '''    play music music_list[&quot;a_promise_from_distant_days_v2&quot;]
        '''    play music music_list[&quot;afterword&quot;]
        '''    play music music_list[&quot;always_ready&quot;]
        '''    play music music_list[&quot;awakening_power&quot;]
        '''    play music music_list[&quot;blow_with_the_fires&quot;]
        '''    play music music_list[&quot;confession_oboe&quot;]
        '''    play music music_list[&quot;dance_of_fireflies&quot;]
        '''    play music music_list[&quot;doomed_to_be_defeated&quot;]
        '''    play music music_list[&quot;door_to_nightmare&quot;]
        '''    play music musi [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property music() As String
            Get
                Return ResourceManager.GetString("music", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property No_in_this() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("No_in_this", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на     show cs normal glasses
        '''    show cs normal stethoscope
        '''    show cs normal
        '''    show cs shy glasses
        '''    show cs shy stethoscope
        '''    show cs shy
        '''    show cs smile glasses
        '''    show cs smile stethoscope
        '''    show cs smile
        '''    show dv angry body
        '''    show dv angry pioneer
        '''    show dv angry pioneer2
        '''    show dv cry body
        '''    show dv cry pioneer
        '''    show dv cry pioneer2
        '''    show dv cry swim
        '''    show dv grin body
        '''    show dv grin pioneer
        '''    show dv grin pioneer2
        '''    show dv grin swim
        '''    show dv [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property sprites() As String
            Get
                Return ResourceManager.GetString("sprites", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на     th &quot;&quot; # ГГ думает
        '''    me &quot;&quot; # Семен говорит
        '''    un &quot;&quot; # Лена говорит
        '''    dv &quot;&quot; # Алиса говорит
        '''    us &quot;&quot; # Ульяна говорит
        '''    sl &quot;&quot; # Славя говорит
        '''    mi &quot;&quot; # Мику говорит
        '''    uv &quot;&quot; # Юля говорит
        '''    el &quot;&quot; # Электроник говорит
        '''    sh &quot;&quot; # Шурик говорит
        '''    mz &quot;&quot; # Женя говорит
        '''    mt &quot;&quot; # Ольга Дмитревна говорит
        '''    cs &quot;&quot; # Виола говорит
        '''    pi &quot;&quot; # Пионер говорит
        '''    ma &quot;&quot; # Маша говорит
        '''    mep &quot;&quot; # Парень говорит
        '''    unp &quot;&quot; # Пионерка (Лена) (если незнакомы) говорит
        '''    dvp &quot;&quot; # Пио [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property text() As String
            Get
                Return ResourceManager.GetString("text", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
