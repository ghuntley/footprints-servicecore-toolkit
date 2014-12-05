## Footprints ServiceCore Toolkit [![Build status](https://ci.appveyor.com/api/projects/status/12gnnje4p39vmbqu?svg=true)](https://ci.appveyor.com/project/ghuntley/footprints-servicecore-toolkit)

Footprints ServiceCore Toolkit is a cross platform portable class library that helps developers integrate with BMC FootPrints ServiceCore.

## Installation

Installation is done via NuGet:

    Install-Package FootprintsServiceCoreToolkit

## Usage


    const string ipsum =
        @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

    var serialized = ipsum.ToFootprints();
    # Lorem__bIpsum__bis__bsimply__bdummy__btext__bof__bthe__bprinting__band__btypesetting__bindustry__d__bLorem__bIpsum__bhas__bbeen__bthe__bindustry__as__bstandard__bdummy__btext__bever__bsince__bthe__b1500s__M__bwhen__ban__bunknown__bprinter__btook__ba__bgalley__bof__btype__band__bscrambled__bit__bto__bmake__ba__btype__bspecimen__bbook__d__bIt__bhas__bsurvived__bnot__bonly__bfive__bcenturies__M__bbut__balso__bthe__bleap__binto__belectronic__btypesetting__M__bremaining__bessentially__bunchanged__d__bIt__bwas__bpopularised__bin__bthe__b1960s__bwith__bthe__brelease__bof__bLetraset__bsheets__bcontaining__bLorem__bIpsum__bpassages__M__band__bmore__brecently__bwith__bdesktop__bpublishing__bsoftware__blike__bAldus__bPageMaker__bincluding__bversions__bof__bLorem__bIpsum__d

    var deserialized = serialized.FromFootprints();
    # Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.

  
