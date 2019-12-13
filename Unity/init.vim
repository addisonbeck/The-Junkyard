filetype on
filetype plugin on
filetype plugin indent on

set wrap
set autoread
set encoding=utf-8
set nocompatible            " disable compatibility to old-time vi
set showmatch               " show matching brackets.
set ignorecase              " case insensitive matching
set mouse=v                 " middle-click paste with mouse
set hlsearch                " highlight search results
set tabstop=4               " number of columns occupied by a tab character
set softtabstop=4           " see multiple spaces as tabstops so <BS> does the right thing
set expandtab               " converts tabs to white space
set shiftwidth=4            " width for autoindents
set autoindent              " indent a new line the same amount as the line just typed
set number                  " add line numbers
set relativenumber
set wildmode=longest,list   " get bash-like tab completions
set nobackup
set nowritebackup
set noswapfile
set hidden
set history=100
set splitbelow
set splitright
set linebreak

filetype plugin indent on   " allows auto-indenting depending on file type
syntax on                   " syntax highlighting
colorscheme default

call plug#begin()
Plug 'scrooloose/nerdtree', { 'on':  'NERDTreeToggle' }
Plug 'junegunn/fzf', { 'dir': '~/.fzf', 'do': './install --all' }
Plug 'valloric/youcompleteme'
Plug 'sirver/ultisnips'
Plug 'adamclerk/vim-razor'
Plug 'mhinz/vim-startify'
Plug 'jiangmiao/auto-pairs'
Plug 'easymotion/vim-easymotion'
Plug 'tpope/vim-surround'
Plug 'ryanoasis/vim-devicons'
Plug 'challenger-deep-theme/vim', { 'as': 'challenger-deep' }
Plug 'vim-airline/vim-airline'
Plug 'vim-airline/vim-airline-themes'
call plug#end()

map <C-b> :NERDTreeToggle<CR>
map <C-p> :FZF<CR>
nmap go <Plug>(easymotion-jumptoanywhere)

:let g:NERDTreeWinSize=50

" Using floating windows of Neovim to start fzf
if has('nvim')
  let $FZF_DEFAULT_OPTS .= ' --border --margin=0,2'

  function! FloatingFZF()
    let width = float2nr(&columns * 0.9)
    let height = float2nr(&lines * 0.6)
    let opts = { 'relative': 'editor',
               \ 'row': (&lines - height) / 2,
               \ 'col': (&columns - width) / 2,
               \ 'width': width,
               \ 'height': height }

    let win = nvim_open_win(nvim_create_buf(v:false, v:true), v:true, opts)
    call setwinvar(win, '&winhighlight', 'NormalFloat:Normal')
  endfunction

  let g:fzf_layout = { 'window': 'call FloatingFZF()' }
endif

colorscheme challenger_deep

if has('nvim') || has('termguicolors')
  set termguicolors
endif

let NERDTreeQuitOnOpen = 1
let NERDTreeAutoDeleteBuffer = 1
let NERDTreeMinimalUI = 1
let NERDTreeDirArrows = 1
let g:startify_change_to_dir = 0
let g:startify_bookmarks = [ 'C:\CCSM', 'C:\Users\beckad\AppData\Local\nvim\init.vim']
